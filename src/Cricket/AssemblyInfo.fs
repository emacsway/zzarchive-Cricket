﻿namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("Cricket")>]
[<assembly: AssemblyProductAttribute("Cricket")>]
[<assembly: AssemblyDescriptionAttribute("An actor library for F#.")>]
[<assembly: AssemblyVersionAttribute("0.0.10")>]
[<assembly: AssemblyFileVersionAttribute("0.0.10")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.0.10"
