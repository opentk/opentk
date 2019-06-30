#r "paket:
nuget Fake.IO.FileSystem
nuget Fake.DotNet.MSBuild
nuget Fake.DotNet.Testing.XUnit2
nuget Fake.Core.Target //"

#load "./.fake/build.fsx/intellisense.fsx"

open Fake.Core
open Fake.IO
open Fake.IO.Globbing.Operators
open Fake.DotNet

// ---------
// Properties
// ---------

let binDir = "./bin/"
let buildDir = "./bin/build/"
let testDir  = "./bin/test/"

// ---------
// Targets
// ---------

Target.create "Clean" (fun _ ->
    Shell.cleanDir binDir
)

Target.create "Build" (fun _ ->
   !! "src/**/*.csproj"
     |> MSBuild.runRelease id buildDir "Build"
     |> Trace.logItems "Build-Output: "
)

Target.create "BuildTest" (fun _ ->
    !! "tests/**/*.csproj"
      |> MSBuild.runDebug id testDir "Build"
      |> Trace.logItems "TestBuild-Output: "
)

// ---------
// Dependencies
// ---------

open Fake.Core.TargetOperators

"Clean"
  ==> "Build"

// ---------
// Startup
// ---------

Target.runOrDefault "Build"
