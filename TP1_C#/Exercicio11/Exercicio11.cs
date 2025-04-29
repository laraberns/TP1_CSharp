using System;

class Program
{
    delegate string StringTransform(string input);

    static string ConcatenarNomeSobrenome(string nome, string sobrenome)
    {
        return nome + " " + sobrenome;
    }

    static string ParaMaiusculas(string s)
    {
        return s.ToUpper();
    }

    static string RemoverEspacos(string s)
    {
        return s.Replace(" ", "");
    }

    static void Main()
    {
        Func<string, string, string> concatenar = ConcatenarNomeSobrenome;

        string nomeCompleto = concatenar("Maria", "Silva");
        Console.WriteLine($"Nome concatenado: {nomeCompleto}");

        StringTransform paraMaiusculas = ParaMaiusculas;
        StringTransform removerEspacos = RemoverEspacos;

        StringTransform pipeline = paraMaiusculas;
        pipeline += removerEspacos;

        string resultadoFinal = pipeline(nomeCompleto);

        Console.WriteLine($"Resultado final do delegate encadeado: {resultadoFinal}"); // Resultado final do delegate encadeado: MariaSilva 
        //Como se trata de um delegate encadeado (multicast), os dois métodos serão executados, mas somente o retorno do último será atribuído à variável resultadoFinal.
    }


}
