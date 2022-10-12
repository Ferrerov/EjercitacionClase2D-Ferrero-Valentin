using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEnClase_DepostioCaotico
{
    internal class DepositoElectrodomestico
    {
        int cantidadMaxima;
        List<Electrodomestico> electrodomesticos;

        public DepositoElectrodomestico(int capacidad)
        {
            this.cantidadMaxima = capacidad;
            electrodomesticos = new List<Electrodomestico>();  
        }
        public bool Agregar(Electrodomestico e)
        {
            if (electrodomesticos.Count < this.cantidadMaxima)
            {
                foreach (Electrodomestico electrodomestico in electrodomesticos)
                {
                    if (Electrodomestico.EsMismoElectrodomestico(electrodomestico, e))
                    {
                        return false;
                    }
                }
                electrodomesticos.Add(e);
                return true;
            }
            return false;
        }
        public bool Quitar(Electrodomestico e)
        {
            foreach (Electrodomestico electrodomestico in electrodomesticos)
            {
                if (Electrodomestico.EsMismoElectrodomestico(electrodomestico, e))
                {
                    electrodomesticos.Remove(electrodomestico);
                    return true;
                }
            }
            return false;
        }
        public override string ToString()
        {
            return $"Capacidad: {this.cantidadMaxima} \nCantidad almacenada: {this.electrodomesticos.Count}";
        }
    }
}
