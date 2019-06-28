using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion9
{
    class Program
    {
        static void Main(string[] args)
        {
            //dos maneras de agregarle los datos al cliente
            ClienteConContacto clientes = new ClienteConContacto(001, "Angel", "pass", "8493422380", "angeld05@live.com",
                                                                        "Dr. Mario Garcia", "Quisqueya", "Distrito");

            //  clsDirecciones direcciones = new clsDirecciones();

            //objeto
            IntSalidas imprimir;

            //leer una cadena de consola
            string cadena = Console.ReadLine();
            if (cadena == "1")
                imprimir = new Impresiones();
            else
                imprimir = new ClsArchivo();
            imprimir.imprimirCliente(clientes);
            Console.ReadKey();
        }
    }
}
