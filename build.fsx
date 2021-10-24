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

// ---------
// Configuration
// ---------

let project = "OpenTK"

let authors = [ "Team OpenTK" ]

let summary = "A set of fast, low-level C# bindings for OpenGL, OpenGL ES and OpenAL."

let license = "https://opensource.org/licenses/MIT"

let projectUrl = "https://github.com/opentk/opentk"

let iconUrl = "https://raw.githubusercontent.com/opentk/opentk/master/docs/files/img/logo.png"

let description =
    "The Open Toolkit is set of fast, low-level C# bindings for OpenGL, OpenGL ES, OpenAL and OpenCL. It runs on all major platforms and powers hundreds of apps, games and scientific research.
    It provides bindings for GLFW windowing, input and a game loop, and is the perfect start for your own game engine.
    

    OpenTK comes with simple and easy to follow tutorials for learning *modern* OpenGL. These are written by the community and represent all of the best practices to get you started.
    Learn how to use OpenTK here:
    https://opentk.net/learn/index.html

    Sample projects that accompany the tutorial can be found here:
    https://github.com/opentk/LearnOpenTK

    We have a very active discord server, if you need help, want to help, or are just curious, come join us!
    https://discord.gg/6HqD48s

    "

let tags = "OpenTK OpenGL OpenGLES GLES OpenAL OpenCL C# F# .NET Mono Vector Math Game Graphics Sound"

let copyright = "Copyright (c) 2006 - 2020 Stefanos Apostolopoulos <stapostol@gmail.com> for the Open Toolkit library."

let solutionFile = "OpenTK.sln"

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
let buildDir = binDir </> "build"
let nugetDir = binDir </> "nuget"
let testDir = binDir </> "test"

// ---------
// Projects & Assemblies
// ---------

let toolProjects =
    !! "src/Generators/**/*.??proj"

let releaseProjects =
    !! "src/**/*.??proj"
    -- "src/Generator/**"
    -- "src/Generator.Bind/**"
    -- "src/Generator.Converter/**"
    -- "src/Generator.Rewrite/**"
    -- "src/SpecificationOpenGL/**"
    -- "src/OpenAL/OpenALGenerator/**"
    -- "src/OpenAL/OpenALTest/**"
    -- "src/OpenAL/OpenTK.OpenAL.Extensions/**"


// Absolutely all test projects.
let allTestProjects =
    !! "tests/**/*.??proj"

// Test projects excluding integration tests (don't run on CI).
let ciTestProjects =
    allTestProjects
    -- "tests/**/*.Integration.??proj"

let nugetCommandRunnerPath =
    ".fake/build.fsx/packages/NuGet.CommandLine/tools/NuGet.exe" |> Fake.IO.Path.convertWindowsToCurrentPath

// ---------
// Other Targets
// ---------

// Lazily install DotNet SDK in the correct version if not available
let install =
    lazy
        (if (DotNet.getVersion id).StartsWith "3" then id
         else DotNet.install (fun options -> { options with Version = DotNet.Version "3.1.100" }))

// Define general properties across various commands (with arguments)
let inline withWorkDir wd = DotNet.Options.lift install.Value >> DotNet.Options.withWorkingDirectory wd

// Set general properties without arguments
let inline dotnetSimple arg = DotNet.Options.lift install.Value arg

module DotNet =
    let run optionsFn framework projFile args =
        DotNet.exec (dotnetSimple >> optionsFn) "run" (sprintf "-f %s -p \"%s\" %s" framework projFile args)

    let runWithDefaultOptions framework projFile args = run id framework projFile args

let pathToSpec = "src" </> "gl.xml"

let specSource = "https://raw.githubusercontent.com/frederikja163/OpenGL-Registry/master/xml/gl.xml"

//let bindingsOutputPath =
//    ""

let asArgs args = args |> String.concat " "


Target.create "UpdateSpec" (fun _ ->
    Trace.log " --- Updating spec --- "
    specSource
    |> Fake.Net.Http.downloadFile ("src" </> "gl.xml")
    |> Trace.logfn "Saved spec at %s"
    ())

Target.create "UpdateBindings" (fun _ ->
    Trace.log " --- Updating bindings --- "
    let framework = "netcoreapp31"
    let projFile = "src/Generator/Generator.fsproj"

    let args =
        [ sprintf "-i %s" (System.IO.Path.GetFullPath pathToSpec)
          "-o " + (System.IO.Path.GetFullPath "src" </> "OpenGL") ]
        |> asArgs
    DotNet.runWithDefaultOptions framework projFile args |> ignore)

Target.create "UpdateBindingsRewrite" (fun _ ->
    Trace.log " --- Updating bindings (rewrite) --- "
    let framework = "netcoreapp31"
    let projFile = "src/Generator.Bind/Generator.Bind.csproj"

    let args = [  ] |> asArgs
    DotNet.runWithDefaultOptions framework projFile args |> ignore)

Target.create "RewriteBindings" (fun _ ->
    Trace.log " --- Rewriting bindings (calli) --- "
    let framework = "netcoreapp31"
    let projFile = "src/Generator.Rewrite/Generator.Rewrite.csproj"
    let bindingsFile = "OpenTK.Graphics.dll"
    let bindingsOutput = "src/OpenTK.Graphics/bin/Release/netstandard2.1"

    let args =
        [ "-a " + (System.IO.Path.GetFullPath bindingsOutput </> bindingsFile)
        ] |> asArgs
    DotNet.runWithDefaultOptions framework projFile args |> ignore)

// ---------
// Build Targets
// ---------

Target.create "Clean" <| fun _ ->
    !! ("./src" </> "OpenTK.Graphics" </> "**/*.*")
    ++ (nugetDir </> "*.nupkg")
    -- ("./src" </> "OpenTK.Graphics" </> "Enums/*.cs")
    -- ("./src" </> "OpenTK.Graphics" </> "*.cs")
    -- ("./src" </> "OpenTK.Graphics" </> "*.csproj")
    -- ("./src" </> "OpenTK.Graphics" </> "ES11/Helper.cs")
    -- ("./src" </> "OpenTK.Graphics" </> "ES20/Helper.cs")
    -- ("./src" </> "OpenTK.Graphics" </> "ES30/Helper.cs")
    -- ("./src" </> "OpenTK.Graphics" </> "OpenGL2/Helper.cs")
    -- ("./src" </> "OpenTK.Graphics" </> "OpenGL4/Helper.cs")
    -- ("./src" </> "OpenTK.Graphics" </> "Wgl/*.*")
    -- ("./src" </> "OpenTK.Graphics" </> "paket")
    |> Seq.iter(Shell.rm)

Target.create "Restore" (fun _ -> DotNet.restore dotnetSimple "OpenTK.sln" |> ignore)

// Generate assembly info files with the right version & up-to-date information
Target.create "AssemblyInfo" (fun _ ->
    //TODO: Create and update the Directory.Build.props file with the version information taken from the releaseNotes value.
    // see https://docs.microsoft.com/en-us/visualstudio/msbuild/customize-your-build?view=vs-2019#directorybuildprops-and-directorybuildtargets
    Trace.traceError "Unimplemented.")

Target.create "Build"( fun _ ->
    let setOptions a =
        let customParams = sprintf "/p:DontGenBindings=true/p:PackageVersion=%s/p:ProductVersion=%s" release.AssemblyVersion release.NugetVersion
        DotNet.Options.withCustomParams (Some customParams) (dotnetSimple a)

    for proj in releaseProjects do
        DotNet.build setOptions proj
    )

Target.create "BuildTest" <| fun _ ->
    !!"tests/**/*.??proj"
    |> Seq.map(fun proj ->
        DotNet.runWithDefaultOptions "netcoreapp3.1" proj "" |> string)
    |> Trace.logItems "TestBuild-Output: "

// Copies binaries from default VS location to expected bin folder
// This preserves subdirectories.
Target.create "CopyBinaries" (fun _ ->
    releaseProjects
    |> Seq.map
        (fun f ->
        ((System.IO.Path.GetDirectoryName f) @@ "bin/Release/netstandard2.0",
         "bin" @@ (System.IO.Path.GetFileNameWithoutExtension f)))
    |> Seq.iter (fun (fromDir, toDir) -> Shell.copyDir toDir fromDir (fun _ -> true)))

open System.IO

let runTests tests =
    let setDotNetOptions (projectDirectory: string): DotNet.TestOptions -> DotNet.TestOptions =
        fun (dotNetTestOptions: DotNet.TestOptions) ->
        { dotNetTestOptions with
                    Common = { dotNetTestOptions.Common with WorkingDirectory = projectDirectory }
                    Configuration = DotNet.BuildConfiguration.Release
                    ResultsDirectory = Some "./result.xml" }.WithRedirectOutput true

    tests
    |> Seq.iter (fun (fullCsProjName: string) ->
            let projectDirectory = Path.GetDirectoryName(fullCsProjName)
            DotNet.test (setDotNetOptions projectDirectory >> dotnetSimple) "")

Target.create "RunCITests" (fun _ ->
    Trace.log " --- Testing CI-safe projects in parallel --- "


    //Looks overkill for only one csproj but just add 2 or 3 csproj and this will scale a lot better
    runTests ciTestProjects)

Target.create "RunAllTests" (fun _ ->
    Trace.log " --- Testing ALL projects in parallel --- "

    //Looks overkill for only one csproj but just add 2 or 3 csproj and this will scale a lot better
    runTests allTestProjects)


Target.create "CreateNuGetPackage" (fun _ ->
    Directory.CreateDirectory nugetDir |> ignore
    let notes = release.Notes |> List.reduce (fun s1 s2 -> s1 + "\n" + s2)

    for proj in releaseProjects do
        Trace.logf "Creating nuget package for Project: %s" proj

        let dir = Path.GetDirectoryName proj
        let templatePath = Path.Combine(dir, "paket")
        let oldTmplCont = File.ReadAllText templatePath
        let newTmplCont = oldTmplCont.Insert(oldTmplCont.Length, sprintf "\nversion \n\t%s\nauthors \n\t%s\nowners \n\t%s\n"
                release.NugetVersion
                (authors |> List.reduce (fun s a -> s + " " + a))
                (authors |> List.reduce (fun s a -> s + " " + a))).Replace("#VERSION#", release.NugetVersion)
        File.WriteAllText(templatePath + ".template", newTmplCont)
        let setParams (p:Paket.PaketPackParams) =
            { p with
                ReleaseNotes = notes
                OutputPath = Path.GetFullPath(nugetDir)
                WorkingDir = dir
                Version = release.NugetVersion
            }
        Paket.pack setParams
    )

Target.create "CreateMetaPackage" (fun _ ->
    let notes = release.Notes |> List.reduce (fun s1 s2 -> s1 + "\n" + s2)

    let deps =
        releaseProjects
        |> Seq.toList
        |> List.map (fun p -> Path.GetFileNameWithoutExtension(p), release.NugetVersion)

    let setParams (p:NuGet.NuGetParams) =
        { p with
            Version = release.NugetVersion
            Authors = authors
            Project = project
            Dependencies = deps
            Summary = summary
            Description = description
            Copyright = copyright
            WorkingDir = binDir
            OutputPath = nugetDir
//                AccessKey = myAccessKey
            Publish = false
            ReleaseNotes = notes
            Tags = tags
            Properties = [
                "Configuration", Environment.environVarOrDefault "buildMode" "Release"
            ]
        }
    Trace.logf "Creating metapackage from opentk.nuspec"
    NuGet.NuGet setParams "opentk.nuspec"
    )

// ---------
// Release Targets
// ---------

open Fake.Api

Target.create "ReleaseOnGitHub" (fun _ ->
    let token =
        match Environment.environVarOrDefault "opentk_github_token" "" with
        | s when not (System.String.IsNullOrWhiteSpace s) -> s
        | _ ->
            failwith
                "please set the github_token environment variable to a github personal access token with repro access."

    let files = !!"bin/*" |> Seq.toList

    GitHub.createClientWithToken token
    |> GitHub.draftNewRelease gitOwner gitName release.NugetVersion (release.SemVer.PreRelease <> None) release.Notes
    //|> GitHub.uploadFiles files
    |> GitHub.publishDraft
    |> Async.RunSynchronously)

Target.create "ReleaseOnNuGet" (fun _ ->
    let apiKey =
        match Environment.environVarOrDefault "opentk_nuget_api_key" "" with
        | s when not (System.String.IsNullOrWhiteSpace s) -> s
        | _ -> failwith "please set the nuget_api_key environment variable to a nuget access token."

    !! (nugetDir </> "*.nupkg")
    |> Seq.iter
        (DotNet.nugetPush (fun opts ->
            { opts with
                PushParams =
                    { opts.PushParams with
                        ApiKey = Some apiKey
                        Source = Some "nuget.org" } })))

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
  ==> "UpdateBindingsRewrite"
  ==> "Build"
  ==> "RewriteBindings"
//  ==> "RunAllTests"
  ==> "All"
  ==> "CreateNuGetPackage"
  ==> "CreateMetaPackage"
  ==> "ReleaseOnNuGet"
  ==> "ReleaseOnGithub"
  ==> "ReleaseOnAll"

"Build"
  ==> "RunCITests"

//"Build"


// ---------
// Startup
// ---------

// Run all targets by default. Invoke 'build <Target>' to override
Target.runOrDefault "All"
