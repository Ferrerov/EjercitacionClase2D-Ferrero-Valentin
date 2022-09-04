using System;

namespace I02_DeseaContinuar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int sumaTotal = 0;

            Console.Write("Ingrese un primer numero: ");
            while (!int.TryParse(Console.ReadLine(), out numeroIngresado))
            {
                Console.Write("Error, ingrese un primer numero valido: ");
            }
            sumaTotal += numeroIngresado;
            
            do
            {
                Console.Write("Ingrese un numero a sumar: ");
                while (!int.TryParse(Console.ReadLine(), out numeroIngresado))
                {
                    Console.Write("Error, ingrese un numero valido: ");
                }
                sumaTotal += numeroIngresado;
                Console.Clear();
                Console.WriteLine($"Suma total: {sumaTotal}");

                Console.Write("¿Desea continuar? (S/N): ");
            } while (Validador.ValidarRespuesta(Console.ReadLine()));

            Console.ReadKey();
            

        }
    }
}
