using SistemaDeEstacionamento.Models;

namespace SistemaDeEstacionamento.Views {
    public class ViewCadastro : View {

        public ViewCadastro() {
            TextoMenu = "Digite as informações para registro do veículo:";
        }

        public override void ExecutarAcoes() {
            Console.Write("\nPlaca do Carro: ");
            string placa = Console.ReadLine();

            if (ViewConsultar.CarrosEstacionados.ContainsKey(placa)) {
                Console.WriteLine("\nEsse veículo já está registrado!");
            } else {
                Carro carro = new(placa, DateTime.Now);
                ViewConsultar.CarrosEstacionados.Add(carro.Placa, carro);
                Console.WriteLine("\nVeículo registrado com sucesso!\nPressione enter para retornar ao menu principal.");
            }
        }
    }  
}
