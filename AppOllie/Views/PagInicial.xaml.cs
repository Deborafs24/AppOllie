namespace AppOllie.Views;

public partial class PagInicial : ContentPage
{
	public PagInicial()
	{
		InitializeComponent();
	}

    private void acesso_Btn_Clicked(object sender, EventArgs e)
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

            if(lista_usuarios.Any(
                i => dados_digitados.Email == i.Email &&
                     dados_digitados.senha == i.senha))
            {

            }

        } catch(Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "Fechar");
        }

        // await Navigation.PushAsync(new Views.Permissoes());
    }

    private void esqueci_Btn_Clicked(object sender, EventArgs e)
    {

    }

    private async void cadastro_Btn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Views.Cadastro());
    }
}