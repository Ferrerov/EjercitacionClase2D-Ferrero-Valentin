using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Arma
    {
        public int danio;
        protected Arma(int danio)
        {
            this.danio = danio;
        }

        public abstract string MensajeDeAtaque();
    }
}
