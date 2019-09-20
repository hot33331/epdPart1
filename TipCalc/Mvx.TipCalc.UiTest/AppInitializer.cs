using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace Mvx.TipCalc.UiTest
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {// we are only using release to not having to deactivate shared runtime in debug
                return ConfigureApp.Android.ApkFile("../../../Mvx.TipCalc.Droid/bin/Release/Mvx.TipCalc.Droid.Mvx.TipCalc.Droid-Signed.apk")
                    .EnableLocalScreenshots()
                    .StartApp();
            }

            if (platform == Platform.iOS)
            {
                return ConfigureApp.iOS.StartApp();
            }

            throw new Exception("Unknown platform");
        }
    }
}