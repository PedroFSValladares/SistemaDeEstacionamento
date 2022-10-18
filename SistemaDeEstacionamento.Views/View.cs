namespace SistemaDeEstacionamento.Views {
    public abstract class View {

        private string text;

        protected string TextoMenu {
            get { 
                return text; 
            }
            set{ 
                text = value; 
            }
        }

        void AlterarTexto() {
            Console.Clear();
            Console.WriteLine(text);
        }

        public abstract void ExecutarAcoes();

        public void Mostrar() {
            AlterarTexto();
            ExecutarAcoes();
        }
    }
}
