namespace AppOllie.Views;

public partial class PagInicial : ContentPage
{
	public PagInicial()
	{
		InitializeComponent();
	}

    private void acesso_Btn_Clicked(object sender, EventArgs e)
    {

    }

    private void esqueci_Btn_Clicked(object sender, EventArgs e)
    {

    }

    private async void cadastro_Btn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Views.Cadastro());

       // await Navigation.PushAsync(new Views.Permissoes());
    }
}