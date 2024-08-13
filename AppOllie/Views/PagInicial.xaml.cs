namespace AppOllie.Views;

public partial class PagInicial : ContentPage
{
	public PagInicial()
	{
		InitializeComponent();
	}

    private async void acesso_Btn_Clicked(object sender, EventArgs e)
    {
        try
        {
            List<DadosUsuario> lista_usuarios = new List<DadosUsuario>()
            {
                new DadosUsuario()
                {
                    Email = "valeria@gmail.com",
                    senha = "1234"
                }
            };

            DadosUsuario dados_digitados = new DadosUsuario()
            {
                Email = txt_email.Text,
                senha = txt_senha.Text
            };

            if (lista_usuarios.Any(
                i => dados_digitados.Email == i.Email &&
                     dados_digitados.senha == i.senha))
            {
                await SecureStorage.Default.SetAsync("usuario_logado", dados_digitados.Email);

                App.Current.MainPage = new Permissoes();
            }
            else
            {
                throw new Exception("Usuário ou senha incorretos.");
            }

        } catch(Exception ex)
        {
            await DisplayAlert("Ops", ex.Message, "Fechar");
        }

        // await Navigation.PushAsync(new Views.Permissoes());
    }

    private void esqueci_Btn_Clicked(object sender, EventArgs e)
    {

    }

    private void cadastro_Btn_Clicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new Cadastro();
        // await Navigation.PushAsync(new Views.Cadastro());
    }
}