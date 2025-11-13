using MauiAppEventos.Models;

namespace MauiAppEventos.Views;

public partial class CadastroEvento : ContentPage
{
    private Evento evento;

    public CadastroEvento()
    {
        InitializeComponent();

        evento = new Evento
        {
            DataInicio = DateTime.Now,
            DataTermino = DateTime.Now,
            NumeroParticipantes = 1
        };

        BindingContext = evento; // ✅ essencial
    }

    private async void CadastrarEvento_Clicked(object sender, EventArgs e)
    {
        // 🔥 força o MAUI a aplicar os valores do Entry ao objeto antes da validação
        this.Focus();

        if (string.IsNullOrWhiteSpace(evento.Nome) ||
            string.IsNullOrWhiteSpace(evento.Local) ||
            evento.NumeroParticipantes <= 0 ||
            evento.CustoPorParticipante <= 0)
        {
            await DisplayAlert("Erro", "Preencha todos os campos corretamente.", "OK");
            return;
        }

        if (evento.DataTermino < evento.DataInicio)
        {
            await DisplayAlert("Erro", "A data de término não pode ser anterior à data de início.", "OK");
            return;
        }

        await Navigation.PushAsync(new ResumoEvento(evento));
    }
}
