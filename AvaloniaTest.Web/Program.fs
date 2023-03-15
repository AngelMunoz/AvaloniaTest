open System.Runtime.Versioning
open Avalonia
open Avalonia.Browser

open AvaloniaTest
open Elmish.Avalonia.AppBuilder

module Program =
    [<assembly: SupportedOSPlatform("browser")>]
    do ()

    [<CompiledName "BuildAvaloniaApp">] 
    let buildAvaloniaApp () = 
        AppBuilder
            .Configure<App>()

    [<EntryPoint>]
    let main argv =
        buildAvaloniaApp()
            .UseElmishBindings()
            .SetupBrowserApp("out")
            |> ignore
        0
