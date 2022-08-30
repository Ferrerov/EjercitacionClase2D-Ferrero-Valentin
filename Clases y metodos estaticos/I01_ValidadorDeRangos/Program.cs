using System;
using System.ComponentModel.DataAnnotations;

namespace I01_ValidadorDeRangos
{
    internal class Program
    {
        private static int cantidad = 10;
        static void Main(string[] args)
        {
            int restantes = cantidad;
            int numero;
            int minNumero = int.MaxValue;
            int maxNumero = int.MinValue;
            int acumulado = 0;

            while (restantes != 0)
            {
                Console.WriteLine("Ingrese un numero ({0} restantes): ", restantes);
                string valorIngresado = Console.ReadLine();
                if (int.TryParse(valorIngresado, out numero) == true && Validador.Validar(numero, -100, 100) == true)
                {
                    restantes--;
                    acumulado = acumulado + numero;
                    if (numero > maxNumero)
                    {
                        maxNumero = numero;
                    }
                    else
                    {
                        if (numero < minNumero)
                        {
                            minNumero = numero;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Error, valor ingresado no valido.");
                }
            }
            int promedio = acumulado / cantidad;
            Console.WriteLine("Valor minimo ingresado: {0} \nValor maximo ingresado: {1}\nValor promedio: {2}", minNumero, maxNumero, promedio);
            Console.ReadKey();

        }
    }
}

