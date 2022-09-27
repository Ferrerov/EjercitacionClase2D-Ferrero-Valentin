using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Hacha : Arma
    {
        private int cantidadDeHojas;

        public Hacha(int danio, int cantidadDeHojas) : base(danio)
        {
            this.cantidadDeHojas = cantidadDeHojas;
        }

        public override string MensajeDeAtaque()
        {
            return $"Zaaaaaaaaaaazz con {base.danio} de daño";
        }
    }
}
