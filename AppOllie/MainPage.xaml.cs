using System.Collections.ObjectModel;

namespace AppOllie
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            
        }

        private async void login_Btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.PagInicial());
        }

        private void login2_Btn_Clicked(object sender, EventArgs e)
        {
            
        }
    }

}
