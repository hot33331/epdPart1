using System.Windows.Input;
using MvvmCross.Commands;
using MvvmCross.ViewModels;
using Todo.Core.Services;

namespace Todo.Core.ViewModels
{
    public class TodoListViewModel:MvxViewModel
    {
        private readonly ITodoService _todoService;

        public TodoListViewModel(ITodoService todoService)
        {
            _todoService = todoService;
        }
        private ICommand _onButtonClicked;
        public ICommand OnButtonClicked
        {
            get
            {
                _onButtonClicked = _onButtonClicked ?? new MvxCommand(DoAdd);
                return _onButtonClicked;
            }
        }

        private void DoAdd()
        {
            throw new System.NotImplementedException();
        }

        private string _text;

        public string Text
        {
            get => _text;
            set => SetProperty(ref _text, value);
        }
        
        private MvxObservableCollection<TodoListItemViewModel> _items;
        MvxObservableCollection<TodoListItemViewModel> Items{
            get => _items;
            set => SetProperty(ref _items, value);
        }
    }
}