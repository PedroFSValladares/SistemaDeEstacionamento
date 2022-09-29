namespace SistemaDeEstacionamento.Models {
    public class Pessoa {
        public string DocumentoDeIdentificao { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public List<Telefone> Telefones { get; set; }
    }
}
