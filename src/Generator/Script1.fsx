type WriteStatements =
    | WriteLine of string
    | Write of string
    | Indent
    | Unindent

type LazyWriter() =
    let statements = ResizeArray()
    
    member __.Add statement = statements.Add statement

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

    member __.For(a: seq<'a>, b : 'a -> LazyWriter) =
        printfn "a is %A" a
        printfn "b is %A" b
        a
        |> Seq.map b
        |> Seq.reduce (fun writer1 writer2 ->
            printfn "writer1 %A" writer1.Statements
            printfn "writer2 %A" writer2.Statements
            for statement in writer1.Statements do
                writer2.Add statement
            writer2
        )

    member __.For(lazyWriter: LazyWriter, b : unit -> LazyWriter) =
        let res = b()
        //for statement in res.st
        printfn "res %A" res
        for statement in res.Statements do
            printfn "statement: %A" statement
            lazyWriter.Add statement
        lazyWriter

    member __.Combine(f,g) = ()

    member __.YieldFrom f  =
        printfn "yield from: %A" f
        f

    //member __.For(a: LazyWriter, b: unit -> WriteStatements list) =
    //    b() |> List.iter (a.Add)
    //    a

    //member __.For(a: string) =
    //    LazyWriter()
    
    //member __.For(a: LazyWriter, b: string) =
    //    a

    //member __.For(a: seq<'a>, fn: ('a -> LazyWriter)) =
    //    a
    //    //|> Seq.map fn
    //    //|> Seq.reduce (fun writer1 writer2 ->
    //    //    for statement in writer1.Statements do
    //    //        writer2.Add statement
    //    //    writer2
    //    //)


    [<CustomOperation("write")>]
    member __.Write(writer: LazyWriter, str) =
        printfn "%A" writer.Statements
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
        for i in 0..10 do
            printfn "%A" i
            write "in loop"
            write "in loop"
            indent
            write "in loop"
            unindent
            write "in loop"
    } |> LazyWriter.execute
