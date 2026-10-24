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
    private async void btnIniciarSesion_Clicked(object? sender, EventArgs e)
    {
        try
        {
            string usuarioIngreso = txtUsuario.Text ?? string.Empty;
            string claveIngreso = txtClave.Text ?? string.Empty;
            if (usuarioIngreso == usuario && claveIngreso == clave)
            {
                await Navigation.PushAsync(new vReporte(usuario));
            }
            else
            {
                await DisplayAlertAsync("Datos incorrectos", "El usuario o la contraseña no son válidos.", "Aceptar");
            }
        }
        catch (Exception ex)
        {
            await DisplayAlertAsync("Error", ex.Message, "Cerrar");

        }
    }

    private async void btnRegistrar_Clicked(object? sender, EventArgs e)
    {
        await Navigation.PushAsync(new vRegistro());
    }
}
