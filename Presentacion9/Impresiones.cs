using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion9
{
    class Impresiones : IntSalidas
    {
        public void emprimirDireccion(clsDirecciones direccion)
        {
            Console.WriteLine(direccion.Calle);
            Console.WriteLine(direccion.Colonia);
            Console.WriteLine(direccion.Estado);
        }

        public void imprimirCliente(AbsCliente clientes)
        {
               Console.WriteLine(clientes.Id);
               Console.WriteLine(clientes.Nombre);
               Console.WriteLine(clientes.Clave);
            
        }
    }
}
