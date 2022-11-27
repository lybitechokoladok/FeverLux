using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FeverluxApp.WPF.Commands
{
    public class RelayCommand : ICommand
    {
        private readonly Action<object> _executeAction;
        private readonly Predicate<object> _canExecuteAction;

        public RelayCommand(Action<object> executeCommand, Predicate<object> canExecuteCommand)
        {
            _executeAction = executeCommand;
            _canExecuteAction = canExecuteCommand;
        }
        public RelayCommand(Action<object> executeCommand)
        {
            _executeAction = executeCommand;
            _canExecuteAction = null;
        }

        public event EventHandler? CanExecuteChanged 
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public bool CanExecute(object? parameter)
        {
            return _canExecuteAction == null ? true: _canExecuteAction(parameter);
        }

        public void Execute(object? parameter)
        {
            _executeAction(parameter);
        }
    }
}
