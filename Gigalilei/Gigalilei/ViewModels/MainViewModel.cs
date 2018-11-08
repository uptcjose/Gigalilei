

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
        public OptionsViewModel Options
        {
            get;
            set;
        }
        #endregion
        #region constructors
        public MainViewModel()
        {
            instance = this;
            this.Login = new LoginViewModel();
        }

        #region singleton
        private static MainViewModel instance;
        public static MainViewModel GetInstance()
        {
            if (instance==null)
            {
                return new MainViewModel();
            }
            return instance;

        }
        #endregion
        #endregion
    }
}
