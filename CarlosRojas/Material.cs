using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarlosRojas
{
    public class Material
    {
        public string Nombre;
        public string Uso;
        public float Tamaño;
        public bool AguaCaliente;

        public void MaterialParaCocinarYPreparar()
        {
            Console.WriteLine("¿Con qué material quiere preparar la comida?");

            Material material1 = new Material();
            material1.Nombre = "Sarten";
            material1.Uso = "Freir";
            material1.Tamaño = 50;

            Material material2 = new Material();
            material2.Nombre = "Espatula";
            material2.Uso = "Freir";
            material2.Tamaño = 30;

            Material material3 = new Material();
            material3.Nombre = "Cucharon";
            material3.Uso = "Remover";
            material3.Tamaño = 30;

            Material material4 = new Material();
            material4.Nombre = "Olla";
            material4.Uso = "Cocinar";
            material4.Tamaño = 60;

            Material material5 = new Material();
            material5.Nombre = "Rodillo";
            material5.Uso = "Amasar";
            material5.Tamaño = 30;

            Material material6 = new Material();
            material6.Nombre = "Colador";
            material6.Uso = "Colar";
            material6.Tamaño = 40;

            Material material7 = new Material();
            material7.Nombre = "Colador";
            material7.Uso = "Colar";
            material7.Tamaño = 40;

            Material material8 = new Material();
            material8.Nombre = "Bol";
            material8.Uso = "Separar";
            material8.Tamaño = 20;

            Material material9 = new Material();
            material9.Nombre = "Balon de gas";
            material9.Uso = "Calentar";
            material9.Tamaño = 90;

            Console.WriteLine(material1.Nombre);
            Console.WriteLine("Uso: " +material1.Uso);
            Console.WriteLine("Tamaño: "+ material1.Tamaño.ToString());

            Console.WriteLine(material2.Nombre);
            Console.WriteLine("Uso: " + material2.Uso);
            Console.WriteLine("Tamaño: " + material2.Tamaño.ToString());

            Console.WriteLine(material3.Nombre);
            Console.WriteLine("Uso: " + material3.Uso);
            Console.WriteLine("Tamaño: " + material3.Tamaño.ToString());

            Console.WriteLine(material4.Nombre);
            Console.WriteLine("Uso: " + material4.Uso);
            Console.WriteLine("Tamaño: " + material4.Tamaño.ToString());

            Console.WriteLine(material5.Nombre);
            Console.WriteLine("Uso: " + material5.Uso);
            Console.WriteLine("Tamaño: " + material5.Tamaño.ToString());

            Console.WriteLine(material6.Nombre);
            Console.WriteLine("Uso: " + material6.Uso);
            Console.WriteLine("Tamaño: " + material6.Tamaño.ToString());

            Console.WriteLine(material7.Nombre);
            Console.WriteLine("Uso: " + material7.Uso);
            Console.WriteLine("Tamaño: " + material7.Tamaño.ToString());

            Console.WriteLine(material8.Nombre);
            Console.WriteLine("Uso: " + material8.Uso);
            Console.WriteLine("Tamaño: " + material8.Tamaño.ToString());

            Console.WriteLine(material9.Nombre);
            Console.WriteLine("Uso: " + material9.Uso);
            Console.WriteLine("Tamaño: " + material9.Tamaño.ToString());
        }

        public void MaterialParaServir()
        {
            Console.WriteLine("¿Dónde va a servir?");

            Material material10 = new Material();
            material10.Nombre = "Plato";
            material10.Uso = "Servir";
            material10.Tamaño = 20;

            Material material11 = new Material();
            material11.Nombre = "Tenedor";
            material11.Uso = "Pinchar";
            material11.Tamaño = 15;

            Material material12 = new Material();
            material12.Nombre = "Cuchillo";
            material12.Uso = "Cortar";
            material12.Tamaño = 15;

            Material material13 = new Material();
            material13.Nombre = "Cuchara";
            material13.Uso = "Tomar";
            material13.Tamaño = 15;

            Material material14 = new Material();
            material14.Nombre = "Vaso";
            material14.Uso = "Tomar";
            material14.Tamaño = 10;

            Console.WriteLine(material10.Nombre);
            Console.WriteLine("Uso: " + material10.Uso);
            Console.WriteLine("Tamaño: " + material10.Tamaño.ToString());

            Console.WriteLine(material11.Nombre);
            Console.WriteLine("Uso: " + material11.Uso);
            Console.WriteLine("Tamaño: " + material11.Tamaño.ToString());

            Console.WriteLine(material12.Nombre);
            Console.WriteLine("Uso: " + material12.Uso);
            Console.WriteLine("Tamaño: " + material12.Tamaño.ToString());

            Console.WriteLine(material13.Nombre);
            Console.WriteLine("Uso: " + material13.Uso);
            Console.WriteLine("Tamaño: " + material13.Tamaño.ToString());

            Console.WriteLine(material14.Nombre);
            Console.WriteLine("Uso: " + material14.Uso);
            Console.WriteLine("Tamaño: " + material14.Tamaño.ToString());
        }

        public void MaterialDeAseo()
        {
            Material material15 = new Material();
            material15.Nombre = "Cuchillo";
            material15.Uso = "Cortar";
            material15.Tamaño = 15;

            Console.WriteLine(material15.Nombre);
        }
    }
}
