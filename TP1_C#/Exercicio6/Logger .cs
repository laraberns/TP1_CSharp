using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_C_.Exercicio6
{
    public delegate void LoggerDelegate();

    internal class Logger
    {
        public void LogToConsole()
        {
            Console.WriteLine("Log no console");
        }

        public void LogToFile()
        {
            Console.WriteLine("Log no file!");
        }

        public void LogToDatabase()
        {
            Console.WriteLine("Log no Database!");
        }
    }
}
