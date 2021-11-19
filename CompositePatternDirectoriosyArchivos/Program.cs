using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternDirectoriosyArchivos
{
    class Program
    {
        static void Main(string[] args)
        {
            Componente root = new Directorio("Root");

            Componente archivo1 = new Archivo("file1.txt", 10);
            Componente archivo2 = new Archivo("file2.txt", 30);
            Componente archivo3 = new Archivo("file3.txt", 120);
            Componente archivo4 = new Archivo("file4.txt", 800);
            Componente archivo5 = new Archivo("file5.txt", 340);

            Componente dir1 = new Directorio("dir1");
            Componente dir2 = new Directorio("dir2");
            Componente dir3 = new Directorio("dir3");

            dir1.AgregarHijo(archivo1);
            dir2.AgregarHijo(archivo2);
            dir3.AgregarHijo(archivo3);
            dir3.AgregarHijo(archivo4);

            dir1.AgregarHijo(dir3);

            root.AgregarHijo(dir1);
            root.AgregarHijo(dir2);
            root.AgregarHijo(archivo5);



            Console.WriteLine($"El tamaño del directorio {root.Nombre} es {root.ObtenerTamanio}");
            Console.WriteLine($"El tamaño del directorio {dir1.Nombre} es {dir1.ObtenerTamanio}");
            Console.WriteLine($"El tamaño del directorio {dir2.Nombre} es {dir2.ObtenerTamanio}");
            Console.WriteLine($"El tamaño del directorio {dir3.Nombre} es {dir3.ObtenerTamanio}");
            Console.ReadKey();
        }
    }
}
