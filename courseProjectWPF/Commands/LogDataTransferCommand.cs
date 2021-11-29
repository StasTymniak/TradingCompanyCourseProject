using courseProjectWPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
namespace courseProjectWPF.Commands
{
    internal class LogDataTransferCommand:ICommand
    {
        private LoginViewModel _logInViewModel;
        private List<int> logData = new List<int>();    

        public LogDataTransferCommand(LoginViewModel logInViewModel)
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
            logData.Clear();
            logData = this._logInViewModel.ServiceAuth.LogIn(this._logInViewModel.UserName, this._logInViewModel.UserPassword);
            if (logData[0] == 1)
            {
                this._logInViewModel.IsLoggedIn = true;
                this._logInViewModel.LoginViewButtonContent = "Log out";
                if (logData[1] == 1)
                {
                    this._logInViewModel.MainViewModel.UserRole = "Admin";
                    
                }
                else
                {
                    this._logInViewModel.MainViewModel.UserRole = "User";
                }
                logData.Clear();
                this._logInViewModel.LoginButtonCommand = new LogOutCommand(this._logInViewModel);
            }
            else
            {
                this._logInViewModel.WrongData();
            }
            
        }
    }
}
