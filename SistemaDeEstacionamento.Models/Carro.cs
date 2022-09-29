namespace SistemaDeEstacionamento.Models {
    public class Carro {
        public string Placa { get; set; }
        public DateTime DataDeChegada { get; set; }

        public Motorista DonoDoCarro { get; set; }
    }
}