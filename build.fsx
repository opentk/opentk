// --------------------------------------------------------------------------------------
// FAKE build script
// --------------------------------------------------------------------------------------

open System
open System.IO
open System.Threading
open Fake.Core
open Fake.DotNet
open Fake.DotNet.NuGet
open Fake.IO

#r "paket:
storage: packages
nuget Fake.IO.FileSystem
nuget Fake.DotNet.MSBuild
nuget Fake.DotNet.Testing.XUnit2
nuget Fake.DotNet.AssemblyInfoFile
nuget Fake.DotNet.NuGet prerelease
nuget Fake.DotNet.Paket
nuget Fake.DotNet.Cli
nuget Fake.Core.Target
nuget Fake.Net.Http
nuget Fake.Api.Github
nuget xunit.runner.console
nuget NuGet.CommandLine
nuget Fake.Core.ReleaseNotes //"

#load "./.fake/build.fsx/intellisense.fsx"

open Fake.IO
open Fake.IO.FileSystemOperators
open Fake.IO.Globbing.Operators

// --------------------------------------------------------------------------------------
// START TODO: Provide project-specific details below
// --------------------------------------------------------------------------------------

// Information about the project are used
//  - for version and project name in generated AssemblyInfo file
//  - by the generated NuGet package
//  - to run tests and to publish documentation on GitHub gh-pages
//  - for documentation, you also need to edit info in "docs/tools/generate.fsx"

// The name of the project
// (used by attributes in AssemblyInfo, name of a NuGet package and directory in 'src')
let project = "OpenTK"

// Short summary of the project
// (used as description in AssemblyInfo and as a short summary for NuGet package)
let summary = "A set of fast, low-level C# bindings for OpenGL, OpenGL ES and OpenAL."

// Longer description of the project
// (used as a description for NuGet package; line breaks are automatically cleaned up)
let description = "The Open Toolkit is set of fast, low-level C# bindings for OpenGL, OpenGL ES and OpenAL. It runs on all major platforms and powers hundreds of apps, games and scientific research."

// List of author names (for NuGet package)
let authors = [ "Stefanos Apostolopoulos" ]

// Tags for your project (for NuGet package)
let tags = "OpenTK OpenGL OpenGLES GLES OpenAL C# F# VB .NET Mono Vector Math Game Graphics Sound"

let copyright = "Copyright (c) 2006 - 2019 Stefanos Apostolopoulos <stapostol@gmail.com> for the Open Toolkit library."

// File system information
let solutionFile  = "OpenTK.sln"

// Pattern specifying assemblies to be tested using NUnit
let testAssemblies = 
    !! "tests/**/bin/Release/net461/*Tests*.dll"
    -- "tests/OpenTK.Tests.Integration/bin/Release/net461/*Tests*.dll"

// Git configuration (used for publishing documentation in gh-pages branch)
// The profile where the project is posted
let gitOwner = "opentk"
let gitHome = "https://github.com/" + gitOwner

// The name of the project on GitHub
let gitName = "opentk"

// The url for the raw files hosted
let gitRaw = Environment.environVarOrDefault "gitRaw" "https://raw.github.com/opentk"

// --------------------------------------------------------------------------------------
// END TODO: The rest of the file includes standard build steps
// --------------------------------------------------------------------------------------

// Read additional information from the release notes document
let release = ReleaseNotes.load "RELEASE_NOTES.md"

let isXamarinPlatform = false //EnvironmentHelper.isMacOS || Environment.OSVersion.Platform = PlatformID.Win32NT

// Helper active pattern for project types
let (|Fsproj|Csproj|Vbproj|) (projFileName:string) =
    match projFileName with
    | f when f.EndsWith "fsproj" -> Fsproj
    | f when f.EndsWith "csproj" -> Csproj
    | f when f.EndsWith "vbproj" -> Vbproj
    | _                           -> failwith (sprintf "Project file %s not supported. Unknown project type." projFileName)

let asArgs args = args |> List.map (fun ( x: string) -> sprintf "\"%s\"" x) |> String.concat " "

let buildProjects =
    !! "src/Generator.*/**.csproj"

let opentkProject =
    !! "src/OpenTK/OpenTK.csproj"

let runtimeProjects =
    let xamarinFilter f =
        if isXamarinPlatform then
            f
        else
            f
            -- "**/OpenTK.Android.csproj"
            -- "**/OpenTK.iOS.csproj"

    !! "src/**/*.??proj"
    ++ "tests/**/OpenTK.Tests*.??proj"
    -- "tests/OpenTK.Tests.Integration/*.??proj"
    -- "src/Generator.*/**.csproj"
    -- "src/OpenTK.GLControl/OpenTK.GLControl.csproj"
    -- "src/OpenTK.GLWidget/OpenTK.GLWidget.csproj"
    |> xamarinFilter

let testProjects = 
    !! "tests/**/OpenTK.Tests*.??proj"

let activeProjects =
    Seq.concat [buildProjects; runtimeProjects]
    
    
let generateBindings() =
    // FIXME: How do we change this?
    for proj in buildProjects do
        DotNet.build id proj

    let result = Shell.Exec("src/Generator.Bind/bin/Release/Bind.exe")
    if result <> 0 then
        failwith "Error running Bind.exe"


// Generate assembly info files with the right version & up-to-date information
Target.create "AssemblyInfo" (fun _ ->
    let getAssemblyInfoAttributes (projectName:string) =
        let projectName =
            if projectName.Contains(".iOS") || projectName.Contains(".Android") then
                projectName.Split('.').[0]
            else
                projectName
        [ AssemblyInfo.Title (projectName)
          AssemblyInfo.Product project
          AssemblyInfo.Description summary
          AssemblyInfo.Version release.AssemblyVersion
          AssemblyInfo.FileVersion release.AssemblyVersion
          AssemblyInfo.CLSCompliant true
          AssemblyInfo.Copyright copyright
        ]

    let getProjectDetails projectPath =
        let projectName = System.IO.Path.GetFileNameWithoutExtension(projectPath: string)
        ( projectPath,
          projectName,
          System.IO.Path.GetDirectoryName(projectPath),
          (getAssemblyInfoAttributes projectName)
        )

    activeProjects
    |> Seq.map getProjectDetails
    |> Seq.iter (fun (projFileName, projectName, folderName, attributes) ->
        match projFileName with
        | Fsproj -> AssemblyInfoFile.createFSharp (folderName @@ "AssemblyInfo.fs") attributes
        | Csproj -> AssemblyInfoFile.createCSharp ((folderName @@ "Properties") @@ "AssemblyInfo.cs") attributes
        | Vbproj -> AssemblyInfoFile.createVisualBasic ((folderName @@ "My Project") @@ "AssemblyInfo.vb") attributes
        )
)

// Copies binaries from default VS location to expected bin folder
// But keeps a subdirectory structure for each project in the
// src folder to support multiple project outputs
Target.create "CopyBinaries" (fun _ ->
    activeProjects
    |>  Seq.map (fun f -> ((System.IO.Path.GetDirectoryName f) @@ "bin/Release", "bin" @@ (System.IO.Path.GetFileNameWithoutExtension f)))
    |>  Seq.iter (fun (fromDir, toDir) -> Shell.copyDir toDir fromDir (fun _ -> true))
)

// --------------------------------------------------------------------------------------
// Clean build results

Target.create "Clean" (fun _ ->
    Shell.cleanDirs ["bin"; "temp"]
)

// --------------------------------------------------------------------------------------
// Build Converter project and updates the signatures.xml file.
Target.create "UpdateSignatures" (fun _ ->
    for proj in buildProjects do
        DotNet.build (fun a -> a) proj
    
    let specUrl = @"https://raw.githubusercontent.com/KhronosGroup/OpenGL-Registry/master/xml/gl.xml"
//    let wglSpecUrl = @"https://raw.githubusercontent.com/KhronosGroup/OpenGL-Registry/master/xml/gl.xml"
    let output = @"src/Generator.Bind/Specifications/GL2/signatures.xml" 
    
    let args = sprintf "--prefix gl --input-files %s --output-file %s" specUrl output
    
    let result = Shell.Exec("src/Generator.Converter/bin/Release/Convert.exe", args)
    if result <> 0 then
        failwith "Error running Convert.exe"
)

// --------------------------------------------------------------------------------------
// Build generator projects, and generates the bindings.
Target.create "GenerateBindings" (fun _ ->
    generateBindings()
)

// --------------------------------------------------------------------------------------
// Build generator projects, and generate bindings if they do not exist.
Target.create "GenerateBindingsIfNeeded" (fun _ ->
    if not (File.Exists("src/OpenTK/Graphics/OpenGL/GL.cs")) then
        generateBindings()
)

// --------------------------------------------------------------------------------------
// Build library & test project

Target.create "Build" (fun _ ->
    for proj in activeProjects do
        DotNet.build id proj
)

Target.create "BuildRewriter" (fun _ ->
    for proj in buildProjects do
        DotNet.build id proj
)

Target.create "BuildOpenTK" (fun _ ->
    for proj in opentkProject do
        DotNet.build id proj
)

Target.create "BuildTests" (fun _ ->
    for proj in testProjects do
        DotNet.build id proj
)

Target.create "RewriteBindings" (fun _ ->
    Trace.log " --- Rewriting bindings --- "
    let framework = "net20"
    let projFile = "src/Generator.Rewrite/Generator.Rewrite.csproj"
    let bindingsFile = "OpenTK.dll"
    let bindingsOutput = "src/OpenTK/bin/Release/net20"

    let targetPath = (System.IO.Path.GetFullPath bindingsOutput </> bindingsFile)
    let args = [ "--assembly"; targetPath; "--signing-key"; "../../../OpenTK.snk" ] |> asArgs
    Shell.Exec("src/Generator.Rewrite/bin/Release/net461/Rewrite.exe", args, ".") |> ignore
    //DotNet.exec id "run" ("--project " + projFile + " " + args) |> ignore
)

// --------------------------------------------------------------------------------------
// Run the unit tests using test runner

Target.create "RunTests" (fun _ ->
    let assemblies = (seq<string>) testAssemblies
    Testing.XUnit2.run (fun p ->
        { p with
            ShadowCopy = true
            TimeOut = TimeSpan.FromMinutes 2.
            XmlOutputPath = Some "TestResults.xml" })
            assemblies
)

// --------------------------------------------------------------------------------------
// Build a NuGet package

Target.create "NuGet" (fun _ ->
    let notes = release.Notes |> List.reduce (fun s1 s2 -> s1 + "\n" + s2)
    let xamExcludes =
        if isXamarinPlatform then
            []
        else
            [ "OpenTK.Android"
              "OpenTK.iOS" ]

    Paket.pack(fun p ->
        { p with
            OutputPath = "bin"
            ExcludedTemplates = xamExcludes
            Version = release.NugetVersion
            ReleaseNotes = notes})
)


Target.create "BuildPackage" ignore

// --------------------------------------------------------------------------------------
// Run all targets by default. Invoke 'build <Target>' to override

Target.create "All" ignore

open Fake.Core.TargetOperators

"Clean"
  ==> "AssemblyInfo"
  ==> "GenerateBindingsIfNeeded"
  ==> "BuildRewriter"
  ==> "BuildOpenTK"
  ==> "RewriteBindings"
  ==> "BuildTests"
  ==> "CopyBinaries"
  ==> "RunTests"
  ==> "All"

"All"
  ==> "NuGet"


Target.runOrDefault "All"
