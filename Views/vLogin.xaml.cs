namespace jmailaExamenn.Views;

public partial class vLogin : ContentPage
{
	public vLogin()
	{
		InitializeComponent();
	}
    Dictionary<string, string> usuarios = new Dictionary<string, string>
        {
            { "estudiante2025", "moviles" },
            { "uisrael", "2025" },
            { "sistemas", "2025_1" }
        };

    private async void Button_Clicked(object sender, EventArgs e)
    {
        string usuario = txtUsuario.Text?.Trim();
        string contrasena = txtContrasena.Text;

        if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contrasena))
        {
            await DisplayAlert("Error", "Ingrese usuario y contraseña", "OK");
            return;
        }

        if (usuarios.ContainsKey(usuario) && usuarios[usuario] == contrasena)
        {
            // Usuario válido, redirige a vCalculoRegistro
            await Navigation.PushAsync(new vCalculoRegistro(usuario));
        }
        else
        {
            await DisplayAlert("Acceso denegado", "Usuario o contraseña incorrectos", "OK");
        }
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new vRegistro());
    }

    private async void Button_Clicked_2(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AcercaDePage(txtUsuario.Text?.Trim()));
    }
}