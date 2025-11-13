using System.ComponentModel;

namespace MauiAppEventos.Models
{
    public class Evento : INotifyPropertyChanged
    {
        private string nome;
        private string local;
        private DateTime dataInicio;
        private DateTime dataTermino;
        private int numeroParticipantes;
        private double custoPorParticipante;

        public string Nome
        {
            get => nome;
            set { nome = value; OnPropertyChanged(nameof(Nome)); }
        }

        public string Local
        {
            get => local;
            set { local = value; OnPropertyChanged(nameof(Local)); }
        }

        public DateTime DataInicio
        {
            get => dataInicio;
            set
            {
                dataInicio = value;
                OnPropertyChanged(nameof(DataInicio));
                OnPropertyChanged(nameof(DuracaoDias));
                OnPropertyChanged(nameof(CustoTotal));
            }
        }

        public DateTime DataTermino
        {
            get => dataTermino;
            set
            {
                dataTermino = value;
                OnPropertyChanged(nameof(DataTermino));
                OnPropertyChanged(nameof(DuracaoDias));
                OnPropertyChanged(nameof(CustoTotal));
            }
        }

        public int NumeroParticipantes
        {
            get => numeroParticipantes;
            set
            {
                numeroParticipantes = value;
                OnPropertyChanged(nameof(NumeroParticipantes));
                OnPropertyChanged(nameof(CustoTotal));
            }
        }

        public double CustoPorParticipante
        {
            get => custoPorParticipante;
            set
            {
                custoPorParticipante = value;
                OnPropertyChanged(nameof(CustoPorParticipante));
                OnPropertyChanged(nameof(CustoTotal));
            }
        }

        public int DuracaoDias => (DataTermino - DataInicio).Days + 1;

        // 🔹 Soma: Participantes × Custo × Dias
        public double CustoTotal => (NumeroParticipantes * CustoPorParticipante) * DuracaoDias;

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}

