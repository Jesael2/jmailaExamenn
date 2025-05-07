namespace jmailaExamenn.Views;

public partial class AcercaDePage : ContentPage
{
    public AcercaDePage(string usuario)
    {
        InitializeComponent();
        lblUsuario.Text = $"Usuario conectado: {usuario}";
    }
}