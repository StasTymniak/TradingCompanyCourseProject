using courseProjectWPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace courseProjectWPF.Commands
{
    internal class LogOutCommand : ICommand
    {
        private LoginViewModel _logInViewModel;

        public LogOutCommand(LoginViewModel logInViewModel)
        {
            this._logInViewModel = logInViewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        { 
            
            this._logInViewModel.UserPassword = "";
            this._logInViewModel.UserName = "";
            this._logInViewModel.MainViewModel.UserRole = "";
            this._logInViewModel.IsLoggedIn = false;
            this._logInViewModel.LoginViewButtonContent = "Log in";
            this._logInViewModel.MainViewModel.SelectedViewModel = null;
            this._logInViewModel.LoginButtonCommand = new LogDataTransferCommand(this._logInViewModel);
        }
    }
}
