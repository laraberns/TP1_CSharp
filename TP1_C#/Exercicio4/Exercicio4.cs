namespace TP1_C_.Exercicio4
{
    internal class Exercicio4
    {
        static void Main(string[] args)
        {
            TemperatureSensor sensor = new TemperatureSensor();

            sensor.TemperatureExceeded += Sensor_TemperatureExceeded;

            Console.WriteLine("Digite a temperatura:");
            double temperatura = double.Parse(Console.ReadLine());

            sensor.ReadTemperature(temperatura);
        }

        private static void Sensor_TemperatureExceeded(object sender, EventArgs e)
        {
            Console.WriteLine("Temperatura acima do limite seguro!");
        }
    }
}
