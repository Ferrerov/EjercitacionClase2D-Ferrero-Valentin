using System;

namespace I04_UnNumeroPerfecto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contadorNumerosPerfectos = 0;
            int acumulador;

            for (int i = 1; i < int.MaxValue; i++)
            {
                acumulador = 0;
                for (int j = 1; j < i - 1; j++)
                {
                    if (i % j == 0)
                    {
                        acumulador += j;
                    }
                }
                if (i == acumulador)
                {
                    Console.WriteLine($"El numero {i} es un numero perfecto.");
                    contadorNumerosPerfectos++;
                }
                if (contadorNumerosPerfectos == 4)
                {
                    break;
                }
            }

        }
    }
}
