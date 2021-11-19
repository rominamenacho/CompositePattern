using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternDirectoriosyArchivos
{
    class Archivo : Componente
    {
        private int _tamanio;

        public Archivo(string nombre, int tamanio) : base(nombre)
        {
            this.Tamanio = tamanio;
        }

        public override int ObtenerTamanio
        {
            get { return Tamanio;  }
        }

        public int Tamanio { get => _tamanio; set => _tamanio = value; }

        public override void AgregarHijo(Componente c) {}

        public override IList<Componente> ObtenerHijos()
        {
            return null;
        }
    }
}
