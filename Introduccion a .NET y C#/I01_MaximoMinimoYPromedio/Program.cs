using System;

namespace I01_MaximoMinimoYPromedio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valorMinimo = 0;
            int valorMaximo = 0;
            float promedio;
            int valorIngresado;
            int acumulador = 0;

            Console.WriteLine("Ingrese cinco numeros para calcular, minimo, maximo y promedio");

            for (int i = 5; i > 0; i--)
            {
                Console.Write($"Ingrese un numero ({i} restantes):");
                while (!int.TryParse(Console.ReadLine(), out valorIngresado))
                {
                    Console.Write($"Ingrese un numero valido ({i} restantes):");
                }
                if (i == 5)
                {
                    valorMinimo = valorIngresado;
                    valorMaximo = valorIngresado;
                }
                else
                {
                    if (valorIngresado < valorMinimo)
                    {
                        valorMinimo = valorIngresado;
                    }
                    else
                    {
                        if (valorIngresado > valorMaximo)
                        {
                            valorMaximo = valorIngresado;
                        }
                    }
                }
                acumulador += valorIngresado;
            }

            promedio = acumulador / 5f;

            Console.WriteLine($"El numero minimo ingresado es: {valorMinimo} \n" +
                $"El numero maximo ingresado es: {valorMaximo} \n" +
                $"El promedio es: {promedio}");
            Console.ReadKey();
        }
    }
}
