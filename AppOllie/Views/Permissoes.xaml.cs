namespace AppOllie.Views;

public partial class Permissoes : ContentPage
{
	public Permissoes()
	{
		InitializeComponent();

        string? usuario_logado = null;

        Task.Run(async () =>
        {
            usuario_logado = await SecureStorage.Default.GetAsync("usuario_logado");
        });
	}

    private async void sair_Btn_Clicked(object sender, EventArgs e)
    {
        bool confirmacao = await DisplayAlert("Tem certeza?", "Sair do App?", "Sim", "Não");

        if (confirmacao)
        {
            SecureStorage.Default.Remove("usuario_logado");
            App.Current.MainPage = new PagInicial();
        }
       // await Navigation.PushAsync(new Views.PagInicial());
    }
}