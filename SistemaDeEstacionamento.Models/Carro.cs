namespace SistemaDeEstacionamento.Models {
    public class Carro {
        public string Placa { get; }
        public DateTime DataEHoraDeChegada { get; }

        public Carro(string placa, DateTime dataEHOra){
            this.Placa = placa;
            this.DataEHoraDeChegada = dataEHOra;
        }
    }
}