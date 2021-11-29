using BLL.Interfaces;
using courseProjectWPF.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace courseProjectWPF.ViewModels
{
    internal class LoginViewModel : BaseViewModel, INotifyPropertyChanged
    {
        private string _userName;
        private string _userPassword;
        private string _loginViewButtonContent = "Log in";
        private MainViewModel _mainViewModel;
        private IServiceAuth _serviceAuth;
        private ICommand _loginButtonCommand;

        public bool IsLoggedIn { get; set; }
        public ICommand LogDataTransferCommand { get; set; }    
        public LoginViewModel(MainViewModel mainViewModel, IServiceAuth serviceAuth)
        {
            this._mainViewModel = mainViewModel;
            this._serviceAuth = serviceAuth;
            this.LoginButtonCommand = new LogDataTransferCommand(this);
        }

        public ICommand LoginButtonCommand
        {
            get => this._loginButtonCommand;
            set
            {
                this._loginButtonCommand = value;
                OnPropertyChanged("LoginButtonCommand");
            }
        }
        public string UserName
        {
            get => this._userName;
            set
            {
                this._userName = value;
                OnPropertyChanged("UserName");
            }
        }

        public string LoginViewButtonContent
        {
            get => this._loginViewButtonContent;
            set
            {
                this._loginViewButtonContent = value;
                OnPropertyChanged("LoginViewButtonContent");
            }
        }

        public MainViewModel MainViewModel
        {
            get => this._mainViewModel;
        }
        public string UserPassword
        {
            get => this._userPassword;
            set
            {
                this._userPassword = value;
                OnPropertyChanged("UserPassword");
            }
        }

        internal void WrongData()
        {
            MessageBox.Show("Wrong username or password", "Error");
        }

        public IServiceAuth ServiceAuth { get => this._serviceAuth; }

        #region INotify
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
        #endregion
    }
}
