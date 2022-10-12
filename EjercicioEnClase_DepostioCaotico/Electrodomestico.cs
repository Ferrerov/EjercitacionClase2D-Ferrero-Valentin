using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEnClase_DepostioCaotico
{
    public enum ETipo { Heladera, Lavarropa, Microondas, Televisor, Cocina };

    public class Electrodomestico
    {
        string modelo;
        string marca;
        ETipo tipo;
        double precio;

        public Electrodomestico(string modelo, string marca, ETipo tipo, double precio)
        {
            this.modelo = modelo;
            this.marca = marca;
            this.tipo = tipo;
            this.precio = precio;
        }

        public string Modelo { get => modelo; set => modelo = value; }
        public string Marca { get => marca; set => marca = value; }
        public ETipo Tipo { get => tipo; set => tipo = value; }
        public double Precio { get => precio; set => precio = value; }

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object? obj)
        {
            Electrodomestico e = obj as Electrodomestico;
            return EsMismoElectrodomestico(e, this);
        }

        public static bool EsMismoElectrodomestico(Electrodomestico a, Electrodomestico b)
        {
            if (a.modelo == b.modelo && a.marca == b.marca && a.tipo == b.tipo && a.precio == b.precio)
            {
                return true;
            }
            return false;
        }


    }
}
