using System;

namespace I05_TirameUnCentro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int primeraSuma;
            int ultimaSuma;

            Console.Write("Ingrese un numero: ");
            if (int.TryParse(Console.ReadLine(), out int numeroIngresado))
            {
                for (int i = 1; i < numeroIngresado; i++)
                {
                    primeraSuma = 0;
                    for (int j = 0; j < i; j++)
                    {
                        primeraSuma += j;
                    }

                    ultimaSuma = 0;
                    for (int k = i + 1; k < primeraSuma; k++)
                    {
                        if (primeraSuma == ultimaSuma || primeraSuma < ultimaSuma)
                        {
                            break;
                        }
                        ultimaSuma += k;
                    }

                    if (primeraSuma == ultimaSuma)
                    {
                        Console.WriteLine($"El numero {i} es un centro numerico.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Error, no ingreso un valor numerico, el programa se cerrara.");
            }

            Console.ReadKey();
        }
    }
}