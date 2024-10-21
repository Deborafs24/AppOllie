namespace AppOllie.Views;

public partial class Tempo : ContentPage
{
	public Tempo()
	{
		InitializeComponent();
	}

    private async void permissoes_Btn_Clicked(object sender, EventArgs e)
    {
        bool confirmacao = await DisplayAlert("Tem certeza?", "Ir para tela permiss�es?", "Sim", "N�o");

        if (confirmacao)
        {
            SecureStorage.Default.Remove("usuario_logado");
            App.Current.MainPage = new Permissoes();
        }
    }
}