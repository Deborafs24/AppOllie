using SQLite;

namespace AppOllie.Views;

public partial class Cadastro : ContentPage
{   
	public Cadastro()
	{
		InitializeComponent();
	}

    private async void cadastro_Btn_Clicked(object sender, EventArgs e)
    {
        bool confirmacao = await DisplayAlert("Voc� foi cadastrado", "Sair da tela de cadastro", "Entrar", "N�o");

        if (confirmacao)
        {
            SecureStorage.Default.Remove("usuario_logado");
            App.Current.MainPage = new Permissoes();
        }
    }

    private void logout_btn_Clicked(object sender, EventArgs e)
    {
    }
}