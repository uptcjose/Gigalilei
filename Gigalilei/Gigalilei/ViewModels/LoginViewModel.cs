



namespace Gigalilei.ViewModels
{
    using System.Windows.Input;
    class LoginViewModel
    {
        #region properties
        public string user
        {
            get;
            set;
        }
        public string password
        {
            get;
            set;
        }
        public bool IsRunning
        {
            get;
            set;
        }
        public bool IsRemember
        {
            get;
            set;
        }
        #region command
        public ICommand LoginCommand
        {
            get;
            set;
        }
        #endregion
        #endregion

        #region constructors
        public LoginViewModel()
        {
            this.IsRemember = true;
        }
        #endregion
    }
}
