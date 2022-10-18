using SistemaDeEstacionamento.Models;

namespace SistemaDeEstacionamento.Views{
    public class ViewDelete : View{

        const decimal TAXA = 1.50M;

        public ViewDelete(){
            TextoMenu = "Digite a placa do veículo para fazer o checkout:\n";
        }

        public override void ExecutarAcoes(){
            Console.Write("Placa do carro: ");
            string placa = Console.ReadLine();
            Carro carro;
            TimeSpan tempo;
            decimal valor;
            if(ViewConsultar.CarrosEstacionados.TryGetValue(placa, out carro)){ 
                tempo = DateTime.Now.Subtract(carro.DataEHoraDeChegada);
                valor = Convert.ToDecimal(tempo.TotalMinutes) * TAXA;
                valor = valor < TAXA ? TAXA : valor;
                ViewConsultar.CarrosEstacionados.Remove(placa);
                Console.WriteLine($"Data e Hora de entrada: {carro.DataEHoraDeChegada}\n" + 
                $"Data e Hora de saída: {DateTime.Now}\n" +
                $"Valor a ser pago: {valor:C}.\n\n" +
                $"Checkout concluído.");
            }else{
                Console.WriteLine("Não existe nenhum veículo cadastrado com essa placa.");
                Console.WriteLine("Pressione enter para retornar ao menu.");
            }
        }
    }
}