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
        private MainViewModel _mainViewModel;
        private IServiceAuth _serviceAuth;

        public ICommand LogDataTransferCommand { get; set; }
        public LoginViewModel(MainViewModel mainViewModel, IServiceAuth serviceAuth)
        {
            this._mainViewModel = mainViewModel;
            this._serviceAuth = serviceAuth;
            this.LogDataTransferCommand = new LogDataTransferCommand(this);

        }

        public string UserName
        {
            get => this._userName;
            set
            {
                this._userName = value;
                OnPropertyChanged("UserRole");
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
