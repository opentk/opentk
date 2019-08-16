type WriteStatements =
    | WriteLine of string
    | Write of string
    | Indent
    | Unindent

and LazyWriter() =
    let statements = ResizeArray()
    
    member __.Add(statement: WriteStatements) = statements.Add statement

    member __.Statements = statements

module LazyWriter =
    
    let execute (lazyWriter: LazyWriter) =
        use backing = new System.IO.StringWriter()
        use writer = new System.CodeDom.Compiler.IndentedTextWriter(backing)
        let executeStatement statement =
            match statement with
            | WriteLine str -> writer.WriteLine str
            | Write str -> writer.Write str
            | Indent -> writer.Indent <- writer.Indent + 1
            | Unindent -> writer.Indent <- max 0 (writer.Indent - 1)


        lazyWriter.Statements
        |> Seq.iter executeStatement 
        writer.Flush()
        backing.Flush()
        backing.ToString()

type WriterV2() =
    member __.Yield(a: int) =
        printfn "yield %d" a
        LazyWriter()

    member __.Yield(()) = LazyWriter()

    member __.For(lazyWriter: LazyWriter, b : unit -> LazyWriter) =
        let res = b()
        //for statement in res.st
        printfn "res %A" res
        for statement in res.Statements do
            lazyWriter.Add statement
        lazyWriter

    member __.Combine(f,g) =
        printfn "combine"
        ()

    member __.Bind(a: seq<LazyWriter>, fn) =
        a
        |> Seq.reduce(fun writer1 writer2 ->
            for statement in writer2.Statements do
                writer1.Add statement
            writer1
        )

    member __.Delay(f) = f()

    [<CustomOperation("write")>]
    member __.Write(writer: LazyWriter, str) =
        printfn "write %A" str
        Write str
        |> writer.Add
        writer

    [<CustomOperation("writeLine")>]
    member __.WriteLine(writer: LazyWriter, str) =
        WriteLine str
        |> writer.Add
        writer
    
    [<CustomOperation("indent")>]
    member __.Indent(writer: LazyWriter) =
        Indent
        |> writer.Add
        writer
    
    [<CustomOperation("unindent")>]
    member __.Unindent(writer: LazyWriter) =
        Unindent
        |> writer.Add
        writer


let writeV2 = WriterV2()

let test2 =
    writeV2 {
        write "a"
        do!
            Seq.init 10 <| fun _ ->
                writeV2 {
                    indent
                    writeLine "a b c"
                    unindent
                    writeLine "d e f"
                }
        write "in loop"
        write "in loop"
        indent
        write "in loop"
        unindent
        write "in loop"
    } |> LazyWriter.execute
