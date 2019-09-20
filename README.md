# epdPart1

## Basics
* What is Xamarin
* Xamarin Native
* Xamarin Forms
   * https://github.com/xamarin/dev-days-labs
* MVVM
   * https://docs.microsoft.com/de-de/xamarin/xamarin-forms/enterprise-application-patterns/mvvm
* Async / Await
   * https://github.com/brminnick/AsyncAwaitBestPractices
   * https://www.youtube.com/watch?v=J0mcYVxJEl0
   * https://www.youtube.com/watch?v=My2gAv5Vrkk

### Xamarin App
* MVVMCross Tutorial TipCalc
    * https://www.mvvmcross.com/documentation/tutorials/tipcalc/the-tip-calc-tutorial
    * `REMARK: TargetFrameworkVersion must be 9 or greater for MVVMCross!` (https://github.com/MvvmCross/MvvmCross/issues/2807)
* Todo App
* Consuming a REST service (see Refit)
* Preferences (see Xamarin Essentials)
* Persistence

## Advanced Topics
* Create nuget libraries and distribute them with nexus
    * https://docs.microsoft.com/en-us/nuget/create-packages/creating-a-package
    * https://docs.microsoft.com/en-us/nuget/create-packages/creating-a-package-dotnet-cli
    * http://blog.majcica.com/2016/01/15/nexus-repository-manager-oss-as-nuget-server/
    * https://docs.microsoft.com/en-us/nuget/reference/nuget-exe-cli-reference
    * https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package-using-the-dotnet-cli
* Bindings for native libraries
    * https://xamarinhelp.com/creating-xamarin-android-binding-library/
    * https://marketplace.visualstudio.com/items?itemName=EgorBogatov.XamarinGradleBindings
    * https://github.com/martijn00/ExoPlayerXamarin
    * https://gist.github.com/JonDouglas/dda6d8ace7d071b0e8cb
    * https://docs.microsoft.com/en-us/xamarin/android/platform/binding-java-library/binding-an-aar
* Data performance /profiling / benchmarking
    * https://www.hanselman.com/blog/BenchmarkingNETCode.aspx
    * https://github.com/dotnet/BenchmarkDotNet
    * https://github.com/jamesmontemagno/monkey-cache/blob/master/performance.xlsx
    * http://jonathanpeppers.com/Blog/xamarin-forms-performance-on-android
* Offline first / caching
    * https://github.com/jamesmontemagno/monkey-cache
    * https://github.com/reactiveui/Akavache
    * https://github.com/MikeCodesDotNet/App-Service-Helpers
* Xamarin Forms
    * Forms pages in native / native views in Forms
        * https://docs.microsoft.com/en-us/xamarin/xamarin-forms/platform/native-views
        * https://docs.microsoft.com/en-us/xamarin/xamarin-forms/platform/native-forms
    * Tuning
        * https://docs.microsoft.com/en-us/xamarin/xamarin-forms/deploy-test/performance
        * https://xamarinhelp.com/improving-xamarin-forms-startup-performance/
        * https://docs.microsoft.com/en-us/xamarin/xamarin-forms/internals/fast-renderers
        * https://github.com/jsuarezruiz/xamarin-forms-perf-playground
* Deal with 2 garbage collectors / profiling
    * https://docs.microsoft.com/en-us/xamarin/android/deploy-test/profiling
    * https://docs.microsoft.com/en-us/xamarin/cross-platform/deploy-test/memory-perf-best-practices
    * https://github.com/PieEatingNinjas/XamarinMemIssuesDemo / https://www.slideshare.net/NCore1/techorama-2018-help-my-xamarin-app-has-memory-issues-pieter-nijs
* Android build optimization
    * https://devblogs.microsoft.com/xamarin/dex-counting-xamarin-android-improved/




## Testing
* Unit tests with nunit
* Code coverage (windows only)
    * https://docs.microsoft.com/en-us/visualstudio/test/using-code-coverage-to-determine-how-much-code-is-being-tested
* automated UI tests with Xamarin UI tests
    * https://docs.microsoft.com/en-us/appcenter/test-cloud/uitest/working-with-repl

## Examples
* App resilient against network problems
    * https://github.com/Depechie/2017-ConnectedApp
* Doing the impossible things with forms
    * https://github.com/Depechie/2018-XamarinOutOfTheBox
* ORM with Entity Framework Core
    * https://github.com/adamped/EFXamarin
* Real life Xamarin Forms Apps
    * https://gist.github.com/davidortinau/5c9129e2bfaabafcb58df07325cb4a90
* Beatiful UI with Xamarin Forms
    * https://github.com/jsuarezruiz/xamarin-forms-goodlooking-UI

## Tools
* Visual Studio (windows and mac)
    * https://visualstudio.microsoft.com/
* Rider (windows and mac)
    * https://www.jetbrains.com/rider/
* mfractor (mac)
    * https://www.mfractor.com/
* resharper (windows)
    * https://www.jetbrains.com/resharper/
* CAKE (build automation system)
    * https://cakebuild.net/
* NUKE (build automation system)
    * https://www.nuke.build/
* Appcenter
    * https://appcenter.ms/
* Gitversion
    * https://github.com/GitTools/GitVersion




## Libraries
* Fody (code weaving for .net)
    * https://github.com/Fody
* Xamarin Essentials (gives developers essential cross-platform APIs for their mobile applications.)
    * https://github.com/xamarin/Essentials
    * https://github.com/xamarin/XamarinComponents
* Shiny (Cross Platform Backgrounding)
    * https://github.com/shinyorg
* Skia (2D drawing and animations)
    * https://github.com/mono/SkiaSharp
* Lottie (Animations)
    * https://github.com/martijn00/LottieXamarin
    * https://lottiefiles.com/
    * https://editor.lottiefiles.com/
* Polly (a .NET resilience and transient-fault-handling library that allows developers to express policies such as Retry, Circuit Breaker, Timeout, Bulkhead Isolation, and Fallback)
    * https://github.com/App-vNext/Polly
* Refit (automatic typesafe REST library)
    * https://github.com/reactiveui/refit
* Automapper
    * https://automapper.org/
* Dapper (OR Mapper, lightweight)
    * https://github.com/StackExchange/Dapper
* Entity Framework Core (OR Mapper)
    * https://github.com/aspnet/EntityFrameworkCore
    * https://xamarinhelp.com/entity-framework-core-xamarin-forms/


