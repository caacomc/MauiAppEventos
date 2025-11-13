using MauiAppEventos.Models;
using MauiAppEventos.Views;
using Microsoft.Extensions.DependencyInjection;

namespace MauiAppEventos
{
    public partial class App : Application
    {
        public List<Evento> lista_evento = new List<Evento>
        {
            new Evento()
            {
            DataInicio = DateTime.Now,
            DataTermino = DateTime.Now,
            CustoPorParticipante = 150.0
            }
        };
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.CadastroEvento());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 500;
            window.Height = 700;

            return window;
        }
    }
}