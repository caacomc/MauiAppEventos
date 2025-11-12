namespace MauiAppEventos
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                double CustoPorParticipante = Convert.ToDouble(txt_CustoPorParticipante.Text);


            } catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }

        }
    }
}
