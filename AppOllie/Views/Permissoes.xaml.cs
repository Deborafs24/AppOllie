namespace AppOllie.Views;

public partial class Permissoes : ContentPage
{
	public Permissoes()
	{
		InitializeComponent();
	}

    private async void sair_Btn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Views.PagInicial());
    }
}