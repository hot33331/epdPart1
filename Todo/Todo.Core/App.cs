using MvvmCross;
using MvvmCross.ViewModels;
using Todo.Core.Services;
using Todo.Core.ViewModels;

namespace Todo.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
           Mvx.IoCProvider.RegisterType<ITodoService, TodoRestService>();

            RegisterAppStart<TodoListViewModel>();
        }
    }
}