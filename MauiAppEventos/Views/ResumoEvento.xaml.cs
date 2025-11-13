using MauiAppEventos.Models;

namespace MauiAppEventos.Views;

public partial class ResumoEvento : ContentPage
{
    public ResumoEvento(Evento evento)
    {
        InitializeComponent();
        BindingContext = evento; // ✅ Conecta o evento à tela
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}