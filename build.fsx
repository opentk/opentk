open Fake.Core
open System
open Fake.DotNet.Testing

#r "paket:
nuget Fake.IO.FileSystem
nuget Fake.DotNet.MSBuild
nuget Fake.DotNet.Testing.XUnit2
nuget Fake.DotNet.AssemblyInfoFile
nuget Fake.DotNet.NuGet
nuget Fake.Core.Target
nuget Fake.Core.ReleaseNotes //"

#load "./.fake/build.fsx/intellisense.fsx"

open Fake.Core
open Fake.IO
open Fake.IO.FileSystemOperators
open Fake.IO.Globbing.Operators
open Fake.DotNet
open Fake.DotNet.NuGet

// ---------
// Configuration
// ---------

let project = "OpenTK"

let authors = [ "Team OpenTK" ]

let summary = "A set of fast, low-level C# bindings for OpenGL, OpenGL ES and OpenAL."

let description = "The Open Toolkit is set of fast, low-level C# bindings for OpenGL, OpenGL ES and OpenAL. It runs on all major platforms and powers hundreds of apps, games and scientific research."

let tags = "OpenTK OpenGL OpenGLES GLES OpenAL C# F# .NET Mono Vector Math Game Graphics Sound"

let copyright = "Copyright (c) 2006 - 2019 Stefanos Apostolopoulos <stapostol@gmail.com> for the Open Toolkit library."

let solutionFile  = "OpenTK.sln"

let gitOwner = "opentk"

let gitHome = "https://github.com/" + gitOwner

// The name of the project on GitHub
let gitName = "opentk"

// The url for the raw files hosted
let gitRaw = Environment.environVarOrDefault "gitRaw" "https://raw.github.com/opentk"

// Read additional information from the release notes document
let release = ReleaseNotes.load "RELEASE_NOTES.md"


// ---------
// Properties
// ---------

let binDir = "./bin/"
let buildDir = "./bin/build/"
let testDir  = "./bin/test/"

// ---------
// Projects & Assemblies
// ---------

let toolProjects =
    !! "src/Generators/**/*.??proj"

let releaseProjects =
    !! "src/**/*.??proj"
    -- "src/Generators/**"

let testProjects =
    !! "tests/**/*.??proj"

let allProjects =
    [toolProjects ; releaseProjects; testProjects ]
    |> Seq.concat
    |> Seq.toList

let testAssemblies = "tests/**/bin/Release/*Tests*.dll"


// ---------
// Other Targets
// ---------

Target.create "UpdateBindings" (fun _ ->
    Trace.traceError "Unimplemented."
)


Target.create "UpdateSpec" (fun _ ->
    Trace.traceError "Unimplemented."
)

// ---------
// Build Targets
// ---------

Target.create "Clean" (fun _ ->
    Shell.cleanDir binDir
)

// Generate assembly info files with the right version & up-to-date information
Target.create "AssemblyInfo" (fun _ ->
    //TODO: Create and update the Directory.Build.props file with the version information taken from the releaseNotes value.
    // see https://docs.microsoft.com/en-us/visualstudio/msbuild/customize-your-build?view=vs-2019#directorybuildprops-and-directorybuildtargets
    Trace.traceError "Assembly info update not yet implemented"
)



Target.create "Build" (fun _ ->
    releaseProjects
    |> MSBuild.runRelease id buildDir "Build"
    |> Trace.logItems "Build-Output: "
)

Target.create "BuildTest" (fun _ ->
    !! "tests/**/*.??proj"
    |> MSBuild.runDebug id testDir "Build"
    |> Trace.logItems "TestBuild-Output: "
)


// Copies binaries from default VS location to expected bin folder
// This preserves subdirectories.
Target.create "CopyBinaries" (fun _ ->
    releaseProjects
    |>  Seq.map (fun f -> ((System.IO.Path.GetDirectoryName f) @@ "bin/Release", "bin" @@ (System.IO.Path.GetFileNameWithoutExtension f)))
    |>  Seq.iter (fun (fromDir, toDir) -> Shell.copyDir toDir fromDir (fun _ -> true))
)

Target.create "RunTests" (fun _ ->
    !! testAssemblies
    |> XUnit2.run (fun p ->
        { p with
            ShadowCopy = true
            TimeOut = TimeSpan.FromMinutes 2.
            XmlOutputPath = Some "TestResults.xml" })
)

Target.create "CreateNuGetPackage" (fun _ ->
    releaseProjects
    |> Seq.iter (NuGet.NuGet(fun p ->
        { p with
            Copyright = copyright
            Authors = authors
            OutputPath = "bin"
            Version = release.NugetVersion
            ReleaseNotes = Fake.Core.String.toLines release.Notes}))
)

// ---------
// Release Targets
// ---------

Target.create "ReleaseOnGithub" (fun _ ->
    Trace.traceError "Unimplemented."
)

Target.create "ReleaseOnNuGetDotOrg" (fun _ ->
    Trace.traceError "Unimplemented."
)

Target.create "ReleaseOnNuGetGallery" (fun _ ->
    Trace.traceError "Unimplemented."
)

Target.create "ReleaseOnAll" ignore


// ---------
// Target relations
// ---------

Target.create "All" ignore

open Fake.Core.TargetOperators

"Clean"
  ==> "AssemblyInfo"
  ==> "Build"
  ==> "CopyBinaries"
  ==> "RunTests"
  ==> "All"
  ==> "CreateNuGetPackage"
  ==> "ReleaseOnGithub"
  ==> "ReleaseOnNugetGallery"
  ==> "ReleaseOnAll"

"Build"
  ==> "UpdateBindings"

"Build"
  ==> "UpdateSpec"


// ---------
// Startup
// ---------

// Run all targets by default. Invoke 'build <Target>' to override
Target.runOrDefault "All"
