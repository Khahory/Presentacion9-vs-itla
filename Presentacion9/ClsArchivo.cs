using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion9
{
    class ClsArchivo : IntSalidas
    {
        public void emprimirDireccion(clsDirecciones direccion)
        {
            Console.WriteLine(direccion.Calle);
            Console.WriteLine(direccion.Colonia);
            Console.WriteLine(direccion.Estado);
        }

        public void imprimirCliente(AbsCliente clientes)
        {
            //objeto para escribir en un archivo
            //actualiza el contenido del mismo archivo
            StreamWriter stringWriter = new StreamWriter(@"C:\Users\Angel\Documents\ArchivoPrueba.log", true);
            stringWriter.WriteLine(clientes.Id);
            stringWriter.WriteLine(clientes.Nombre);
            stringWriter.WriteLine(clientes.Clave);
            stringWriter.Close();
            Console.WriteLine("Archivo creado");
        }
    }
}
