using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace Mvx.TipCalc.UiTest
{
    [TestFixture(Platform.Android)]
    //[TestFixture(Platform.iOS)]
    public class AppTests
    {
        IApp app;
        Platform platform;

        public AppTests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void WelcomeTextIsDisplayed()
        {
            AppResult[] results = app.WaitForElement(c => c.Text("SubTotal"));
            //app.Repl();


            Assert.IsTrue(results.Any());
        }
    }
}