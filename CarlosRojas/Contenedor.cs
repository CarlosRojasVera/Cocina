using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarlosRojas
{
    public class Contenedor
    {
        public string Nombre;
        public float CantParaContener;
        

        public void Contenedores()
        {
            Console.WriteLine("Contenedor a usar");

            Contenedor contenedor1 = new Contenedor();
            contenedor1.Nombre = "Jarra";
            contenedor1.CantParaContener = 1000;

            Contenedor contenedor2 = new Contenedor();
            contenedor2.Nombre = "Azucarera";
            contenedor2.CantParaContener = 300;

            Contenedor contenedor3 = new Contenedor();
            contenedor3.Nombre = "Salero";
            contenedor3.CantParaContener = 170;

            Contenedor contenedor4 = new Contenedor();
            contenedor4.Nombre = "Taza";
            contenedor4.CantParaContener = 400;

            Contenedor contenedor5 = new Contenedor();
            contenedor5.Nombre = "Tetera";
            contenedor5.CantParaContener = 1200;

            Console.WriteLine(contenedor1.Nombre);
            Console.WriteLine("Contiene" + contenedor1.CantParaContener.ToString());

            Console.WriteLine(contenedor2.Nombre);
            Console.WriteLine("Contiene" + contenedor2.CantParaContener.ToString());

            Console.WriteLine(contenedor3.Nombre);
            Console.WriteLine("Contiene" + contenedor3.CantParaContener.ToString());

            Console.WriteLine(contenedor4.Nombre);
            Console.WriteLine("Contiene" + contenedor4.CantParaContener.ToString());

            Console.WriteLine(contenedor5.Nombre);
            Console.WriteLine("Contiene" + contenedor5.CantParaContener.ToString());


        }
        

    }
}
