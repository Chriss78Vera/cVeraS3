using static System.Runtime.InteropServices.JavaScript.JSType;

namespace cVeraS3.Views;

public partial class vReporte : ContentPage
{
    public vReporte(string usuario)
    {
        InitializeComponent();//
        DisplayAlertAsync("HOLA" + usuario, "Bienvenido", "ok");
    }
}