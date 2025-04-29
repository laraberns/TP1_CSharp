namespace TP1_C_.Exercicio6
{
    internal class Exercicio6
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger();

            Action logDelegate = null;
            logDelegate += logger.LogToConsole;
            logDelegate += logger.LogToFile;
            logDelegate += logger.LogToDatabase;

            logDelegate();
        }

    }
}
