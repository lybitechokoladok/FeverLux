using FeverluxApp.WPF.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FeverluxApp.WPF.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        private string _username;
        private string _password;
        private string _errorMessage;
        private bool _isViewVisible = true;

        public string Username 
        {
            get => _username;
            set 
            {
                _username = value;
                OnPropetyChanged(nameof(Username));
            }
        }
        public string Password 
        {
            get => _password; 
            set 
            { 
                _password = value;
                OnPropetyChanged(nameof(Password));
            } 
        }
        public string ErrorMessage
        { 
            get => _errorMessage;
            set {
                _errorMessage = value;
                OnPropetyChanged(nameof(ErrorMessage));
            }
        }
        public bool IsViewVisible
        {
            get => _isViewVisible;
            set 
            {
                _isViewVisible = value;
                OnPropetyChanged(nameof(IsViewVisible));
            }
        }

        public ICommand LoginCommand { get; }

        public LoginViewModel() 
        {
            LoginCommand = new RelayCommand(ExecuteLoginCommand, CanExecuteLoginCommand);
        }

        private bool CanExecuteLoginCommand(object obj)
        {
            return true;
        }

        private void ExecuteLoginCommand(object obj)
        {
            IsViewVisible= false;
        }
    }
}
