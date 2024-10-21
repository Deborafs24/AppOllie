namespace AppOllie.Views;

public partial class Tempo : ContentPage
{
	public Tempo()
	{
		InitializeComponent();
	}

    private async void permissoes_Btn_Clicked(object sender, EventArgs e)
    {
        bool confirmacao = await DisplayAlert("Tem certeza?", "Ir para tela permissões?", "Sim", "Não");

        if (confirmacao)
        {
            SecureStorage.Default.Remove("usuario_logado");
            App.Current.MainPage = new Permissoes();
        }
    }
}