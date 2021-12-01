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
    internal class LoginViewModel : BaseViewModel, INotifyPropertyChanged, IDataErrorInfo
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

        #region Validation
        private bool _isValidPass;
        private bool _isValidUserName;
        private bool _buttonLogInIsEnable;
        public bool ButtonLogInIsEnable
        {
            get => this._buttonLogInIsEnable;
            set
            {
                this._buttonLogInIsEnable = value;
                OnPropertyChanged("ButtonLogInIsEnable");
            }
        }
        public bool IsValidUserName
        {
            get => this._isValidUserName;
            set
            {
                if (this._isValidUserName != value)
                    this._isValidUserName = value;
            }
        }
        public bool IsValidPass
        {
            get => this._isValidPass;
            set
            {
                if (this._isValidPass != value)
                    this._isValidPass = value;
            }
        }
        public string Error { get { return null; } }
        public Dictionary<string, string> ErrorCollection { get; private set; } = new Dictionary<string, string>();
        public string this[string name]
        {
            get
            {
                string _result = null;
                switch (name)
                {
                    case "UserPassword":
                        if (string.IsNullOrWhiteSpace(UserPassword))
                        {
                            _result = "Password cannot be empty";
                            IsValidPass = false;
                        }
                        else if (UserPassword.Contains(" "))
                        {
                            _result = "Using space is not allowed";
                            IsValidPass = false;
                        }
                        else
                        {
                            IsValidPass = true;
                        }
                        break;
                    case "UserName":
                        if (string.IsNullOrWhiteSpace(UserName))
                        {
                            _result = "UserName cannot be empty";
                            IsValidUserName = false;
                        }
                        else if (UserName.Contains(" "))
                        {
                            _result = "Using space is not allowed";
                            IsValidUserName = false;
                        }
                        else
                        {
                            IsValidUserName = true;
                        }
                        break;
                }

                if (ErrorCollection.ContainsKey(name))
                    ErrorCollection[name] = _result;
                else if (_result != null)
                    ErrorCollection.Add(name, _result);
                if (IsValidUserName && IsValidPass)
                    ButtonLogInIsEnable = true;
                else
                    ButtonLogInIsEnable = false;

                OnPropertyChanged("ErrorCollection");
                return _result;
            }
        }

        #endregion

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
