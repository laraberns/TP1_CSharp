namespace TP1_C_.Exercicio1
{
    internal class Exercicio2
    {
        static void MensagemPortugues(string idioma)
        {
            Console.WriteLine("Seja bem-vindo(a)!");
        }

        static void MensagemIngles(string idioma)
        {
            Console.WriteLine("Welcome!");
        }

        static void MensagemEspanhol(string idioma)
        {
            Console.WriteLine("¡Bienvenido(a)!");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Escolha um idioma (português, inglês ou espanhol): ");
            string idioma = Console.ReadLine()?.Trim().ToLower();

            Action<string> exibirMensagem;

            if (idioma == "português")
            {
                exibirMensagem = MensagemPortugues;
            }
            else if (idioma == "inglês")
            {
                exibirMensagem = MensagemIngles;
            }
            else if (idioma == "espanhol")
            {
                exibirMensagem = MensagemEspanhol;
            }
            else
            {
                exibirMensagem = (idioma) => Console.WriteLine("Idioma não suportado.");
            }

            exibirMensagem(idioma);
        }
    }
}
