using System;

namespace I02_ErrorAlCubo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero: ");
            double valorIngresado;
            //double number = double.Parse(valorIngresado);
            while (!double.TryParse(Console.ReadLine(), out valorIngresado))
            {
                Console.Write("ERROR. ¡Reingresar número!: ");
            }

            double cuadrado = Math.Pow(valorIngresado, 2);
            double cubo = Math.Pow(valorIngresado, 3);

            Console.WriteLine($"Cuadrado de {valorIngresado}: {cuadrado}\n" +
                $"Cubo de {valorIngresado}: {cubo}");
        }
    }
}
