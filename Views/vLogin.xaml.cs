namespace cVeraS3.Views;

public partial class vLogin : ContentPage
{
    string usuario = " ", clave = " ";
    public vLogin()
    {
        InitializeComponent();
    }

    public vLogin(string usuarioNuevo, string claveNueva)
    {
        InitializeComponent();
        usuario = usuarioNuevo;
        clave = claveNueva;
    }
    private void btnIniciarSesion_Clicked(object sender, EventArgs e)
    {
        try
        {
            string usuarioIngreso = txtUsuario.Text;
            string claveIngreso = txtClave.Text;
            if (usuarioIngreso == usuario && claveIngreso == clave)
            {
                Navigation.PushAsync(new vReporte(usuario));
            }
            else
            {
                DisplayAlertAsync("Alerta", "Usuario/Clave Incorrectos", "ok");
            }
        }
        catch (Exception ex)
        {
            DisplayAlertAsync("Error", ex.Message, "Cerrar");

        }
    }

    private void btnRegistrar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new vRegistro());
    }
}