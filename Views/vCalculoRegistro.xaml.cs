namespace jmailaExamenn.Views;

public partial class vCalculoRegistro : ContentPage
{
    string usuarioConectado;

    public vCalculoRegistro(string usuario)
    {
        InitializeComponent();
        usuarioConectado = usuario;
        lblUsuario.Text = $"Usuario conectado: {usuario}";
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        if (double.TryParse(txtMonto.Text, out double montoInicial))
        {
            
            double cuotaMensual = montoInicial * 0.15;
            txtCuota.Text = cuotaMensual.ToString("F2");
        }
        else
        {
            DisplayAlert("Error", "Ingrese un monto válido", "OK");
        }
    }

    private async void OnVerResumenClicked(object sender, EventArgs e)
    {
        string nombre = txtNombre.Text;
        string apellido = txtApellido.Text;
        string va = pickerVA.SelectedItem?.ToString() ?? "No seleccionado";
        string fecha = dateFecha.Date.ToString("dd/MM/yyyy");
        string ciudad = pickerCiudad.SelectedItem?.ToString() ?? "No seleccionada";
        string monto = txtMonto.Text;
        string cuota = txtCuota.Text;

        string resumen = $"Usuario: {usuarioConectado}\n" +
                         $"Nombre: {nombre} {apellido}\n" +
                         $"VA: {va}\n" +
                         $"Fecha: {fecha}\n" +
                         $"Ciudad: {ciudad}\n" +
                         $"Monto Inicial: {monto}\n" +
                         $"Cuota Mensual: {cuota}";

        await DisplayAlert("Resumen", resumen, "Cerrar");
    }

   


    private void Button_Clicked_2(object sender, EventArgs e)
    {
        if (double.TryParse(txtMonto.Text, out double montoInicial))
        {
            // Supongamos que la cuota mensual se calcula como el 10% del monto
            double cuotaMensual = montoInicial * 0.10;
            txtCuota.Text = cuotaMensual.ToString("F2");
        }
        else
        {
            DisplayAlert("Error", "Ingrese un monto válido", "OK");
        }
    }
}


