using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternDirectoriosyArchivos
{
    class Directorio : Componente
    {
        private List<Componente> _hijos;
        public Directorio(string nombre) : base(nombre)
        {
            _hijos = new List<Componente>();
        }
              
        public override void AgregarHijo(Componente c)
        {
            _hijos.Add(c);
        }

        public override IList<Componente> ObtenerHijos()
        {
            return _hijos.ToArray();
        }
        public override int ObtenerTamanio
        {
            get
                {
                int t = 0;
                foreach(var item in _hijos)
                {
                    t += item.ObtenerTamanio;
                }
                return t;
            }
        }
    }
}
