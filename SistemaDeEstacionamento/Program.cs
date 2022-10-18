using SistemaDeEstacionamento.Models;
using SistemaDeEstacionamento.Views;

namespace SistemaDeEstacionamento{
    class Program{
        Dictionary<int, View> views;
        public static readonly Dictionary<string, Carro> carrosEstacionados = new();
        View viewAtual;
        int response;

        public Program(){
            response = 0;
            views = new() {
                { 0, new DefaultView() },
                { 1, new ViewCadastro() },
                { 2, new ViewDelete() },
                { 3, new ViewConsultar() }
            };
        }

        void Run(){
            do{
                if(views.TryGetValue(response, out viewAtual)) {
                    viewAtual.Mostrar();
                } else {
                    Console.WriteLine("Opção inválida");
                }
                if(!int.TryParse(Console.ReadLine(), out response)){
                    Console.WriteLine("Opção inválida");
                }
            }while(response != 5);
        }

        public static void Main(string[] args) => new Program().Run();
    }
}