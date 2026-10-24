namespace cVeraS3.Views;

public partial class vRegistro : ContentPage
{
    public vRegistro()
    {
        InitializeComponent();
    }

    private async void btnGuardar_Clicked(object? sender, EventArgs e)
    {
        try
        {
            string usuarioNuevo = txtUsuarioNuevo.Text ?? string.Empty;
            string claveUsuario = txtClave.Text ?? string.Empty;
            await Navigation.PushAsync(new vLogin(usuarioNuevo, claveUsuario));
            await DisplayAlertAsync("Registro exitoso", "El usuario se guardó correctamente.", "Aceptar");
        }
        catch (Exception ex)
        {
            await DisplayAlertAsync("Error", ex.Message, "Cerrar");

        }
    }
}
