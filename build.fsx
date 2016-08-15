// --------------------------------------------------------------------------------------
// FAKE build script
// --------------------------------------------------------------------------------------

#r @"packages/FAKE/tools/FakeLib.dll"
open Fake
open Fake.Git
open Fake.AssemblyInfoFile
open Fake.ReleaseNotesHelper
open Fake.UserInputHelper
open Fake.Testing
open System
open System.IO

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

let copyright = "Copyright (c) 2006 - 2016 Stefanos Apostolopoulos <stapostol@gmail.com> for the Open Toolkit library."

// File system information 
let solutionFile  = "OpenTK.sln"

// Pattern specifying assemblies to be tested using NUnit
let testAssemblies = "tests/**/bin/Release/*Tests*.dll"

// Git configuration (used for publishing documentation in gh-pages branch)
// The profile where the project is posted
let gitOwner = "opentk" 
let gitHome = "https://github.com/" + gitOwner

// The name of the project on GitHub
let gitName = "opentk"

// The url for the raw files hosted
let gitRaw = environVarOrDefault "gitRaw" "https://raw.github.com/opentk"

// --------------------------------------------------------------------------------------
// END TODO: The rest of the file includes standard build steps
// --------------------------------------------------------------------------------------

// Read additional information from the release notes document
let release = LoadReleaseNotes "RELEASE_NOTES.md"

let isXamarinPlatform = false //EnvironmentHelper.isMacOS || Environment.OSVersion.Platform = PlatformID.Win32NT


// Helper active pattern for project types
let (|Fsproj|Csproj|Vbproj|) (projFileName:string) = 
    match projFileName with
    | f when f.EndsWith "fsproj" -> Fsproj
    | f when f.EndsWith "csproj" -> Csproj
    | f when f.EndsWith "vbproj" -> Vbproj
    | _                           -> failwith (sprintf "Project file %s not supported. Unknown project type." projFileName)


let activeProjects = 
    let xamarinFilter f = 
        if isXamarinPlatform then
            f
        else
            f
            -- "**/OpenTK.Android.csproj"
            -- "**/OpenTK.iOS.csproj"

    !! "src/**/*.??proj"
    -- "**/OpenTK.GLWidget.csproj"
    |> xamarinFilter

// Generate assembly info files with the right version & up-to-date information
Target "AssemblyInfo" (fun _ ->
    let getAssemblyInfoAttributes projectName =
        [ Attribute.Title (projectName)
          Attribute.Product project
          Attribute.Description summary
          Attribute.Version release.AssemblyVersion
          Attribute.FileVersion release.AssemblyVersion
          Attribute.CLSCompliant true
          Attribute.Copyright copyright  ]

    let getProjectDetails projectPath =
        let projectName = System.IO.Path.GetFileNameWithoutExtension(projectPath)
        ( projectPath, 
          projectName,
          System.IO.Path.GetDirectoryName(projectPath),
          (getAssemblyInfoAttributes projectName)
        )

    !! "src/**/*.??proj"
    |> Seq.map getProjectDetails
    |> Seq.iter (fun (projFileName, projectName, folderName, attributes) ->
        match projFileName with
        | Fsproj -> CreateFSharpAssemblyInfo (folderName @@ "AssemblyInfo.fs") attributes
        | Csproj -> CreateCSharpAssemblyInfo ((folderName @@ "Properties") @@ "AssemblyInfo.cs") attributes
        | Vbproj -> CreateVisualBasicAssemblyInfo ((folderName @@ "My Project") @@ "AssemblyInfo.vb") attributes
        )
)

// Copies binaries from default VS location to expected bin folder
// But keeps a subdirectory structure for each project in the 
// src folder to support multiple project outputs
Target "CopyBinaries" (fun _ ->
    activeProjects
    |>  Seq.map (fun f -> ((System.IO.Path.GetDirectoryName f) @@ "bin/Release", "bin" @@ (System.IO.Path.GetFileNameWithoutExtension f)))
    |>  Seq.iter (fun (fromDir, toDir) -> CopyDir toDir fromDir (fun _ -> true))
)

// --------------------------------------------------------------------------------------
// Clean build results

Target "Clean" (fun _ ->
    CleanDirs ["bin"; "temp"]
)

// --------------------------------------------------------------------------------------
// Build library & test project

Target "Build" (fun _ ->
    activeProjects
    |> MSBuildRelease "" "Rebuild"
    |> ignore
)

// --------------------------------------------------------------------------------------
// Run the unit tests using test runner

Target "RunTests" (fun _ ->
    !! testAssemblies
    |> xUnit2 (fun p ->
        { p with
            ShadowCopy = true
            TimeOut = TimeSpan.FromMinutes 2.
            XmlOutputPath = Some "TestResults.xml" })
)

// --------------------------------------------------------------------------------------
// Build a NuGet package

Target "NuGet" (fun _ ->
    let xamExcludes =
        if isXamarinPlatform then
            []
        else
            [ "OpenTK.Android"
              "OpenTK.iOS" ]


    Paket.Pack(fun p -> 
        { p with
            OutputPath = "bin"
            ExcludedTemplates = "OpenTK.GLWidget" :: xamExcludes
            Version = release.NugetVersion
            ReleaseNotes = toLines release.Notes})
)


Target "BuildPackage" DoNothing

// --------------------------------------------------------------------------------------
// Run all targets by default. Invoke 'build <Target>' to override

Target "All" DoNothing

"Clean"
  ==> "AssemblyInfo"
  ==> "Build"
  ==> "CopyBinaries"
//  ==> "RunTests"
  ==> "All"

"All" 
  ==> "NuGet"


RunTargetOrDefault "All"
