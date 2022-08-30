using System;

namespace I06_AniosBisiestos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("El siguiente programa obtendra los años bisiestos del rango que determine a continuacion.");
            Console.Write("Ingrese el año de inicio: ");
            int anioDeInicio;
            while (!int.TryParse(Console.ReadLine(), out anioDeInicio) || anioDeInicio < 0)
            {
                Console.Write("Error, ingrese un año de inicio valido: ");
            }
            Console.Write("Ingrese el año final: ");
            int anioFinal;
            while (!int.TryParse(Console.ReadLine(), out anioFinal) || anioFinal < 0 || anioFinal < anioDeInicio)
            {
                Console.Write("Error, ingrese un año final valido: ");
            }

            for (int i = anioDeInicio; i <= anioFinal; i++)
            {
                if (i % 4 == 0)
                {
                    if (!(i % 100 == 0 && i % 400 != 0))
                    {
                        Console.WriteLine($"El año {i} es bisiesto.");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}

