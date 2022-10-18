namespace SistemaDeEstacionamento.Views {
    public class DefaultView : View {

        public DefaultView() {
            TextoMenu = "Escolha uma opção:\n\n" +
                "1 - Registrar entrada de veículo.\n" +
                "2 - Registrar saída de veículo\n" +
                "3 - Consultar veículos\n" +
                "5 - Sair";
        }

        public override void ExecutarAcoes() {
            Console.Write("\nDigite a opção desejada: ");
        }
    }
}