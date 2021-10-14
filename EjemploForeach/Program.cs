using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            //Objeto de la coleccion List
            List<string> productos = new List<string>();

            //Llenado de productos la coleccion
            productos.Add("Impresora");
            productos.Add("Mouses");
            productos.Add("Teclado");
            productos.Add("Parlante");

            //Mostrando los regsitro
            foreach (var p in productos)
            {
                MessageBox.Show(p);
            }

            Console.ReadKey();
        }
    }
}
