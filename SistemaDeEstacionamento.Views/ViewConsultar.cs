using SistemaDeEstacionamento.Models;

namespace SistemaDeEstacionamento.Views {
    public class ViewConsultar : View{

        static readonly Dictionary<string, Carro> carrosCadastrados = new();
        
        public static Dictionary<string, Carro> CarrosEstacionados { get { return carrosCadastrados; } }

        public ViewConsultar(){
            TextoMenu = " ___________________________________________\n" +
                        "| Placa do veículo | Data e Hora de entrada |\n" +
                        "|-------------------------------------------|";
        }
        public override void ExecutarAcoes() {
            foreach (var carro in CarrosEstacionados) {
                int sizeLeft = (20 + carro.Value.Placa.Length) / 2;
                string placaDoCaro = carro.Value.Placa.PadLeft(sizeLeft , ' ').PadRight(18 ,' ');
                Console.WriteLine($"|{placaDoCaro}|  {carro.Value.DataEHoraDeChegada}   |");
            }
            Console.WriteLine("|___________________________________________|");
        }
    }
}
