namespace cVeraS3.Views;

public partial class vRegistro : ContentPage
{
    public vRegistro()
    {
        InitializeComponent();
    }

    private void btnGuardar_Clicked(object sender, EventArgs e)
    {
        try
        {
            string usuarioNuevo = txtUsuarioNuevo.Text;
            string claveUsuario = txtClave.Text;
            Navigation.PushAsync(new vLogin(usuarioNuevo, claveUsuario));
            DisplayAlertAsync("Alerta", "Usuario Guardado", "OK");
        }
        catch (Exception ex)
        {
            DisplayAlertAsync("Error", ex.Message, "Cerrar");

        }
    }
}