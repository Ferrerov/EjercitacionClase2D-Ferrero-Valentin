using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Arco : Arma
    {
        private int distanciaMaxima;

        public Arco(int danio, int distanciaMaxima) : base(danio)
        {
            this.distanciaMaxima = distanciaMaxima;
        }

        public override string MensajeDeAtaque()
        {
            return $"Piuu piuu piuu con {base.danio} de daño";
        }
    }
}
