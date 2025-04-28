namespace TP1_C_.Exercicio3
{
    internal class Exercicio3
    {
        public static double CalcularBase(double altura, double largura)
        {
            return altura * largura;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Escolha a base de um retângulo: ");
            double base_retangulo = double.Parse(Console.ReadLine());
            Console.WriteLine("Escolha a altura de um retângulo: ");
            double altura_retangulo = double.Parse(Console.ReadLine());

            Func<double, double, double> calcularArea = CalcularBase;

            double area = calcularArea(altura_retangulo, base_retangulo);

            Console.WriteLine($"A área do retângulo é: {area}");
        }
    }
}
