namespace cVeraS3.Views;

public partial class vReporte : ContentPage
{
    public vReporte(string usuario)
    {
        InitializeComponent();
        Title = $"Resumen de {usuario}";
    }
}
