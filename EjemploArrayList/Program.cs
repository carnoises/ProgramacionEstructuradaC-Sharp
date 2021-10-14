using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Objeto de la coleccion ArrayList
            ArrayList alumnos = new ArrayList();

            //Llenando de alumnos la coleccion
            alumnos.Add("Lucy Pacheco Hernandez");
            alumnos.Add("Carla Gallegos Silva");
            alumnos.Add("Heidi Rengifo Reategui");

            //Mostrando los registro 
            foreach (String a in alumnos)
            {
                MessageBox.Show(a);
            }

            Console.ReadKey();
        }
    }
}
