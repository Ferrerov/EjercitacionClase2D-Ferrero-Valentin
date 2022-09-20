using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I01_Sobre_EscribiendoEsasAdvertencias
{
    public abstract class Sobreescrito
    {
        protected string miAtributo;

        public Sobreescrito()
        {
            miAtributo = "Probar abstractos";
        }

        public abstract string MiPropiedad { get; }

        public override string ToString()
        {
            return "¡Este es mi método ToString sobrescrito!";
        }

        public override bool Equals(object? obj)
        {
            return typeof(object) == this.GetType();    
        }

        public override int GetHashCode()
        {
            return 1142510181;  
        }
    }
}
