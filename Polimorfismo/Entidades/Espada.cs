using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Espada : Arma
    {
        private int longitudDeHoja;
        public Espada(int danio, int longitudDeHoja) : base(danio)
        {
            this.longitudDeHoja = longitudDeHoja;
        }
        public override string MensajeDeAtaque()
        {
            return $"Espadazooooooo con {base.danio} de daño";
        }
    }
}
