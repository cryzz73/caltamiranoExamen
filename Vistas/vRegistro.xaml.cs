namespace caltamiranoExamen.Vistas;

public partial class vRegistro : ContentPage
{
	public vRegistro(string cajaUsuario)
	{
        InitializeComponent();
        DisplayAlert("Bienvenido", cajaUsuario, "Cerrar");
        lblUsuario.Text = "Usuario conectado " + cajaUsuario;
    }

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {

      
        if (!double.TryParse(txtMontoInicial.Text, out double montoInicial))
        {
            DisplayAlert("Error", "Por favor ingrese un monto inicial válido.", "OK");
            return;
        }

 
        double montoRestante = 1500 - montoInicial;
        double montoPorCuota = montoRestante / 4;
       double montoConInteres = montoPorCuota * 1.04;
        double montoTotal = montoConInteres + montoInicial;

        txtPagoMensual.Text = montoConInteres.ToString("C");
       
    }

    private void btnResumen_Clicked(object sender, EventArgs e)
    {

        string nombre = txtNombre.Text;
        string apellido = txtApellido.Text;
        string edad = txtEdad.Text;
        string fecha = datePicker.Date.ToString("dd/MM/yyyy");
        string pais = pickerPais.SelectedItem?.ToString();
        string ciudad = pickerCiudad.SelectedItem?.ToString();
        string montoInicial = txtMontoInicial.Text;
        string pagoMensual = txtPagoMensual.Text;
        string cajaUsuario = lblUsuario.Text;
        string montoTotal = txtmontoTotal.Text;
        


        vResumen resumenPage = new vResumen(nombre, apellido, edad, fecha, pais, ciudad, montoInicial, pagoMensual, cajaUsuario,montoTotal);
              Navigation.PushAsync(resumenPage);
    }
}