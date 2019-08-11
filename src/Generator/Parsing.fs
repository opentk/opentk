module Parsing

let (|IsPointerType|_|) input =
    match input with
    | "" -> None
    | _ when input.EndsWith('*') ->
        input.Substring(0, input.Length - 1)
        |> Some
    | _ -> None

open Types

let tryParseType (str:string) =
    let str = str.Replace("const", "").Replace(" ", "")
    let rec tryParse str =
        match str with
        | IsPointerType inner ->
            tryParse inner
            |> Option.map Pointer
        | "GLboolean" -> Some GLboolean
        | "GLbyte" -> Some GLbyte
        | "GLchar" -> Some GLchar
        | "GLcharARB" -> Some GLcharARB
        | "GLclampf" -> Some GLclampf
        | "GLenum" -> Some GLenum
        | "GLdouble" -> Some GLdouble
        | "GLfixed" -> Some GLfixed
        | "GLfloat" -> Some GLfloat
        | "GLhalfNV" -> Some GLhalfNV
        | "GLint" -> Some GLint
        | "GLint64" -> Some GLint64
        | "GLint64EXT" -> Some GLint64EXT
        | "GLuint" -> Some GLuint
        | "GLuint64" -> Some GLuint64
        | "GLuint64EXT" -> Some GLuint64EXT
        | "GLintptr" -> Some GLintptr
        | "GLshort" -> Some GLshort
        | "GLushort" -> Some GLushort
        | "GLsizei" -> Some GLsizei
        | "GLubyte" -> Some GLubyte
        | "GLsizeiptr" -> Some GLsizeiptr
        | "GLvdpauSurfaceNV" -> Some GLvdpauSurfaceNV
        | "void" -> Some Void
        | "GLbitfield" -> Some GLbitfield
        | "GLclampd" -> Some GLclampd
        | "GLclampx" -> Some GLclampx
        | "GLeglClientBufferEXT" -> Some GLeglClientBufferEXT
        | "GLeglImageOES" -> Some GLeglImageOES
        | "GLhandleARB" -> Some GLhandleARB
        | "GLintptrARB" -> Some GLintptrARB
        | "GLsizeiptrARB" -> Some GLsizeiptrARB
        | "GLsync" -> Some GLsync
        | "struct_cl_context" -> Some Struct_cl_context
        | "struct_cl_event" -> Some Struct_cl_event
        | "GLDEBUGPROC" -> Some GLDEBUGPROC
        | "GLDEBUGPROCAMD" -> Some GLDEBUGPROCAMD
        | "GLDEBUGPROCARB" -> Some GLDEBUGPROCARB
        | "GLDEBUGPROCKHR" -> Some GLDEBUGPROCKHR
        | _ ->
            printfn "input %s is not a valid type" str
            None
    tryParse str