namespace jmailaExamenn.Views;

public partial class vCalculoRegistro : ContentPage
{


    public vCalculoRegistro(string usuario)
    {
        InitializeComponent();
        lblUsuario.Text = $"Usuario conectado: {usuario}";
    }
}
