

namespace Gigalilei.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class MainViewModel
    {
        #region properties
        public LoginViewModel Login
        {
            get;
            set;
        }
        #endregion
        #region constructors
        public MainViewModel()
        {
            this.Login = new LoginViewModel();
        }
        #endregion
    }
}
