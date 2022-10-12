namespace EjercicioEnClase_DepostioCaotico
{
    public class Golosina
    {
        private string nombre;
        private string marca;
        private string codigoBarra;

        public string Nombre { get => nombre;}
        public string Marca { get => marca;}
        public string CodigoBarra { get => codigoBarra;}

        public Golosina(string nombre, string marca, string codigoBarra)
        {
            this.nombre = nombre;
            this.marca = marca;
            this.codigoBarra = codigoBarra;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object? obj)
        {
            Golosina g = obj as Golosina;
            return EsMismaGolosina(g, this);    
        }
        public static bool EsMismaGolosina(Golosina a, Golosina b)
        {
            if(a.nombre == b.nombre && a.marca == b.marca && a.codigoBarra == b.codigoBarra )
            {
                return true;
            }
            return false;
        }
    }
}