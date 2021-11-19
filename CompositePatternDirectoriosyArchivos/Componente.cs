using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternDirectoriosyArchivos
{
   public abstract class Componente
    {
        private string nombre;

        protected Componente(string nombre)
        {
            this.Nombre = nombre;
        }

        public string Nombre { get => nombre; set => nombre = value; }

        public abstract void AgregarHijo(Componente c);
        public abstract IList<Componente> ObtenerHijos();
        public abstract int ObtenerTamanio { get; }
    }
}
