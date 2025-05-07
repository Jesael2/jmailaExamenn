namespace jmailaExamenn.Views;

public partial class vRegistro : ContentPage
{
	public vRegistro()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        string nuevoUsuario = txtNuevoUsuario.Text?.Trim();
        string nuevaContrasena = txtNuevaContrasena.Text;

        if (string.IsNullOrWhiteSpace(nuevoUsuario) || string.IsNullOrWhiteSpace(nuevaContrasena))
        {
            await DisplayAlert("Error", "Por favor, llene todos los campos.", "OK");
            return;
        }

    

        await DisplayAlert("Éxito", "Usuario registrado correctamente.", "OK");

        // Regresa al login o navega al cálculo, como prefieras:
        await Navigation.PopAsync(); // vuelve al login
    }
}
    
