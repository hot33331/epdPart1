using MvvmCross;
using MvvmCross.ViewModels;
using Todo.Core.ViewModels;

namespace Todo.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
           // Mvx.IoCProvider.RegisterType<ICalculationService, CalculationService>();

            RegisterAppStart<TodoListViewModel>();
        }
    }
}