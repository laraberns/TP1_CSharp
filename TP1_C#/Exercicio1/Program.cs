namespace TP1_C_.Exercicio1
{
    internal class Program
    {
        public delegate double CalculateDiscount(double valor);

        public static double CalculateDiscountMethod(double valor)
        {
            return valor * 0.9;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Digite o preço original de um produto: ");
            double precoProduto = double.Parse(Console.ReadLine());

            CalculateDiscount handler = CalculateDiscountMethod;

            Console.WriteLine($"O preço com desconto é: R$ {handler(precoProduto)}");
        }
    }
}
