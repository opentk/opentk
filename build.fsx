open Fake.Core
open System
open Fake.DotNet.Testing

#r "paket:
storage: packages
nuget Fake.IO.FileSystem
nuget Fake.DotNet.MSBuild
nuget Fake.DotNet.Testing.XUnit2
nuget Fake.DotNet.AssemblyInfoFile 
nuget Fake.DotNet.NuGet prerelease
nuget Fake.DotNet.Cli
nuget Fake.Core.Target
nuget Fake.DotNet.Cli
nuget Fake.Net.Http
nuget Fake.Api.Github
nuget xunit.runner.console
nuget NuGet.CommandLine
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
    -- "src/Generator/**"
    -- "src/SpecificationOpenGL/**"

let testProjects =
    !! "tests/**/*.??proj"

let nugetCommandRunnerPath = ".fake/build.fsx/packages/NuGet.CommandLine/tools/NuGet.exe" |> Fake.IO.Path.convertWindowsToCurrentPath

// ---------
// Other Targets
// ---------

// Lazily install DotNet SDK in the correct version if not available
let install = lazy DotNet.install DotNet.Versions.FromGlobalJson

// Define general properties across various commands (with arguments)
let inline withWorkDir wd =
    DotNet.Options.lift install.Value
    >> DotNet.Options.withWorkingDirectory wd

// Set general properties without arguments
let inline dotnetSimple arg = DotNet.Options.lift install.Value arg

module DotNet =
    let run optionsFn framework projFile args =
        DotNet.exec (dotnetSimple >> optionsFn)
            "run"
            (sprintf "-f %s -p \"%s\" %s" framework projFile args)

    let runWithDefaultOptions framework projFile args =
        run id framework projFile args

let pathToSpec = "src" </> "gl.xml"

let specSource =
    "https://raw.githubusercontent.com/frederikja163/OpenGL-Registry/master/xml/gl.xml"

//let bindingsOutputPath =
//    ""

let asArgs args =
    args |> String.concat " "


Target.create "UpdateSpec" (fun _ ->
    Trace.log " --- Updating spec --- "
    specSource
    |> Fake.Net.Http.downloadFile ("src" </> "gl.xml")
    |> Trace.logfn "Saved spec at %s"
    ()
)

Target.create "UpdateBindings" (fun _ ->
    Trace.log " --- Updating bindings --- "
    let framework = "netcoreapp22"
    let projFile = "src/Generator/Generator.fsproj"
    let args =
        [ sprintf "-i %s" (System.IO.Path.GetFullPath pathToSpec)
          "-o " + (System.IO.Path.GetFullPath "src" </> "OpenGL")
        ] |> asArgs
    DotNet.runWithDefaultOptions framework projFile args
    |> ignore
)

// ---------
// Build Targets
// ---------

Target.create "Clean" (fun _ ->
    Shell.cleanDir binDir
)

Target.create "Restore" (fun _ ->
     Shell.Exec("dotnet", "restore OpenTK.sln") |> ignore
 )

// Generate assembly info files with the right version & up-to-date information
Target.create "AssemblyInfo" (fun _ ->
    //TODO: Create and update the Directory.Build.props file with the version information taken from the releaseNotes value.
    // see https://docs.microsoft.com/en-us/visualstudio/msbuild/customize-your-build?view=vs-2019#directorybuildprops-and-directorybuildtargets
    Trace.traceError "Unimplemented."
)


Target.create "Build" (fun _ ->
    releaseProjects
    |> MSBuild.runRelease id "" "Build"
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
    |>  Seq.map (fun f -> ((System.IO.Path.GetDirectoryName f) @@ "bin/Release/netstandard2.0", "bin" @@ (System.IO.Path.GetFileNameWithoutExtension f)))
    |>  Seq.iter (fun (fromDir, toDir) -> Shell.copyDir toDir fromDir (fun _ -> true))
)

open System.IO
open Fake.Core
open Fake.IO.Globbing.Operators
open Fake.DotNet

Target.create "RunTests" (fun _ ->
  Trace.log " --- Testing projects in parallel --- "
  let setDotNetOptions (projectDirectory:string) : (DotNet.TestOptions-> DotNet.TestOptions) =
    fun (dotNetTestOptions:DotNet.TestOptions) -> 
      { dotNetTestOptions with
          Common        = { dotNetTestOptions.Common with WorkingDirectory = projectDirectory}
          Configuration = DotNet.BuildConfiguration.Release
          ResultsDirectory = Some "./result.xml"
      }.WithRedirectOutput true

  //Looks overkill for only one csproj but just add 2 or 3 csproj and this will scale a lot better
  testProjects
  |> Seq.iter (
    fun fullCsProjName -> 
      let projectDirectory = Path.GetDirectoryName(fullCsProjName)
      DotNet.test (setDotNetOptions projectDirectory) ""
    )
)

Target.create "CreateNuGetPackage" (fun _ ->
    let optsFn options =
        { options with
            DotNet.PackOptions.OutputPath = (Some "Bin")
        }
    releaseProjects
    |> Seq.iter(DotNet.pack optsFn)
)

// ---------
// Release Targets
// ---------

open Fake.Api

Target.create "ReleaseOnGitHub" (fun _ ->
    let token =
        match Environment.environVarOrDefault "github_token" "" with
        | s when not (System.String.IsNullOrWhiteSpace s) -> s
        | _ -> failwith "please set the github_token environment variable to a github personal access token with repro access."

    let files =
        !! "bin/*"
        |> Seq.toList

    GitHub.createClientWithToken token
    |> GitHub.draftNewRelease gitOwner gitName release.NugetVersion (release.SemVer.PreRelease <> None) release.Notes
    |> GitHub.uploadFiles files
    |> GitHub.publishDraft
    |> Async.RunSynchronously

)

Target.create "ReleaseOnNuGetGallery" (fun _ ->
    let apiKey =
        match Environment.environVarOrDefault "nuget_api_key" "" with
        | s when not (System.String.IsNullOrWhiteSpace s) -> s
        | _ -> failwith "please set the nuget_api_key environment variable to a nuget access token."

    !! "bin/*.nupkg"
    |> Seq.iter(
        DotNet.nugetPush (fun opts ->
            { opts with
                PushParams =
                    { opts.PushParams with
                        ApiKey = Some apiKey
                        Source = Some "nuget.org"
                    }
            }
        )
    )
)

Target.create "ReleaseOnAll" ignore

// ---------
// Target relations
// ---------

Target.create "All" ignore

open Fake.Core.TargetOperators

"Clean"
  ==> "Restore"
  ==> "AssemblyInfo"
  ==> "UpdateSpec"
  ==> "UpdateBindings"
  ==> "Build"
  ==> "CopyBinaries"
  ==> "RunTests"
  ==> "All"
  ==> "CreateNuGetPackage"
  ==> "ReleaseOnNuGetGallery"
  ==> "ReleaseOnGithub"
  ==> "ReleaseOnAll"

//"Build"


// ---------
// Startup
// ---------

// Run all targets by default. Invoke 'build <Target>' to override
Target.runOrDefault "All"
