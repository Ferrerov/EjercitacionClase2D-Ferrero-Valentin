using System;

namespace I03_LosPrimos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valorIngresado;
            string strValorIngresado = "";
            string respuesta;

            while (strValorIngresado != "salir")
            {
                Console.Write("Ingrese un numero (o 'salir' para terminar el programa): ");
                strValorIngresado = Console.ReadLine();

                if (double.TryParse(strValorIngresado, out valorIngresado))
                {
                    for (int i = 0; i < valorIngresado; i++)
                    {
                        if (EsPrimo(i) == true)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    Console.Write("Desea continuar? (s/n)");
                    respuesta = Console.ReadLine();
                    while (respuesta != "s" && respuesta != "n")
                    {
                        Console.Write("Ingrese una respuesta valida, desea continuar? (s/n)");
                        respuesta = Console.ReadLine();
                    }
                    if (respuesta == "n")
                    {
                        break;
                    }

                }
                else
                {
                    if (strValorIngresado == "salir")
                    {
                        Console.WriteLine("Saliendo del programa.");
                    }
                    else
                    {
                        Console.WriteLine("Error, el numero ingresado no es valido.");
                    }
                }
            }

            static bool EsPrimo(int numero)
            {
                for (int i = 2; i < numero; i++)
                {
                    if ((numero % i) == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
