namespace cVeraS3
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Visita registrada: {count}";
            else
                CounterBtn.Text = $"Visitas registradas: {count}";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }
}
