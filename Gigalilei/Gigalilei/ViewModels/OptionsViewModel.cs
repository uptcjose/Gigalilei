



namespace Gigalilei.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using Models;
    using Services;
    using Xamarin.Forms;

    class OptionsViewModel:BaseViewModel
    {
        #region service
        private ApiService  apiService;
        #endregion
        #region atributes
        private ObservableCollection<Users> users;
        #endregion


        #region properties
        public ObservableCollection<Users> Users
        {
            get { return this.users; }
            set { SetValue(ref users, value); }
        }
        #endregion
        #region constructors
        public OptionsViewModel()
        {
            this.apiService = new ApiService();
            this.loadUsers();
        }
        #endregion
        private async void loadUsers()
        {
            var response = await this.apiService.GetList<Users>
                (
                "http://www.gigalileogalilei.edu.co/software/WebService/VerUsuarios.php",
                "",
                ""
                );
            if (!response.IsSuccess)
            {
                await Application.Current.MainPage.DisplayAlert(
                    "errorsaso",
                    response.Message,
                    "Aceptar");
                return;
            }
            var list = (List<Users>)response.Result;
            this.Users = new ObservableCollection<Users>(list);
        }
    }
}
