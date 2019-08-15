using MvvmCross;
using MvvmCross.ViewModels;
using Mvx.TipCalc.Core.Services;
using Mvx.TipCalc.Core.ViewModels;

namespace Mvx.TipCalc.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            MvvmCross.Mvx.IoCProvider.RegisterType<ICalculationService, CalculationService>();

            RegisterAppStart<TipViewModel>();
        }
    }
}