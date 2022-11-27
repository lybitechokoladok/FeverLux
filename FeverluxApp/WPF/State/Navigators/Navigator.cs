using FeverluxApp.WPF.Commands;
using FeverluxApp.WPF.Models;
using FeverluxApp.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FeverluxApp.WPF.State.Navigators
{
    public class Navigator :ObservableObject ,INavigator
    {
        private ViewModelBase _currentViewModel;
        public ViewModelBase CurrentViewModel 
        {
            get => _currentViewModel;
            set 
            {
                _currentViewModel= value;
                OnPropetyChanged(nameof(CurrentViewModel));
            }
        }

        public ICommand UpdateCurrentViewModelCommand => new UpdateCurrentViewModelCommand(this);
    }
}
