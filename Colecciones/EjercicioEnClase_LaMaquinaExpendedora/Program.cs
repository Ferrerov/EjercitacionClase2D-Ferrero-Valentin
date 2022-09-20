using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.ConstrainedExecution;

namespace EjercicioEnClase_LaMaquinaExpendedora
{
    internal class Program
    {
        /*
        1.Crear e instanciar el Dictionary<TKey, TValue> llamado maquinaExpendedora.
        2.Cargar por lo menos 10 elementos en formato clave-valor(clave= numero de posición, valor= nombre del producto)
        3.Una vez cargado, desarrollar el flujo del proyecto de consola de modo que:
        •Al iniciarse muestre al usuario todos los productos con sus respectivos códigos.
        •Pida al usuario elegir el número del producto que quiere
        •Al seleccionar número, informar al usuario que recibió ese producto y volver a mostrar todos los productos SIN el producto que ya eligió
        •El programa se repetirá indefinidamente hasta que el usuario elija la opción “S”.
        BONUS: Refactorizar el programa para que en vez de tener un diccionario INT – STRING, tengamos un diccionario INT – PRODUCTO (que contenga nombre y precio del producto)
        */
        static void Main(string[] args)
        {
            Console.WriteLine("-------La maquina expendedora-------");
            Dictionary<int, string> maquinaExpendedora = new Dictionary<int, string>();
            int codigoDelProducto;
            string respuesta;

            maquinaExpendedora.Add(1, "Gasesosa");
            maquinaExpendedora.Add(2, "Papas fritas");
            maquinaExpendedora.Add(3, "Bolsa de caramelos");
            maquinaExpendedora.Add(4, "Chocolate");
            maquinaExpendedora.Add(5, "Gomitas");
            maquinaExpendedora.Add(6, "Cerveza");
            maquinaExpendedora.Add(7, "Pañuelos");
            maquinaExpendedora.Add(8, "Galletitas");
            maquinaExpendedora.Add(9, "Yerba");
            maquinaExpendedora.Add(10, "Chicles");

            do
            {
                foreach (KeyValuePair<int, string> producto in maquinaExpendedora)
                {
                    Console.WriteLine($"Codigo: {producto.Key} Producto: {producto.Value}");
                }

                Console.Write("\nIngrese el codigo del producto que desea: ");
                while (!(int.TryParse(Console.ReadLine(), out codigoDelProducto)))
                {
                    Console.Write("Ingrese un codigo de producto valido: ");
                }
                Console.WriteLine($"Usted recibio el producto {maquinaExpendedora[codigoDelProducto]}");
                maquinaExpendedora.Remove(codigoDelProducto);
                Console.Write("Desea salir? (s/n): ");
                respuesta = Console.ReadLine();
            } while (respuesta.ToUpper() != "s");
        }
    }
}
