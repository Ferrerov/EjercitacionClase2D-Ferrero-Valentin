using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEnClase_DepostioCaotico
{
    public class DepositoGolosina
    {
        private int cantidadMaxima;
        private List<Golosina> golosinas;

        public DepositoGolosina(int capacidad)
        {
            cantidadMaxima = capacidad;
            golosinas = new List<Golosina>();
        }

        public bool Agregar(Golosina g)
        {
            if(golosinas.Count < this.cantidadMaxima)
            {
                foreach(Golosina golosina in golosinas)
                {
                    if(Golosina.EsMismaGolosina(golosina, g))
                    {
                        return false;
                    }
                }
                golosinas.Add(g);
                return true;
            }
            return false;
        }
        public bool Quitar(Golosina g)
        {
            foreach(Golosina golosina in golosinas)
            {
                if(Golosina.EsMismaGolosina(golosina, g))
                {
                    golosinas.Remove(golosina);
                    return true;
                }
            }
            return false;
        }

        public override string ToString()
        {
            return $"Capacidad: {this.cantidadMaxima} \nCantidad almacenada: {this.golosinas.Count}";
        }

    }
}
