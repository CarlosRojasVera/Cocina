using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarlosRojas
{
    public class Artefacto
    {
        public string Nombre { get; set; }
        public float CantElectricidad { get; set; }
        public float CantGas { get; set; }
        

        


        public void ArtElectrico()
        {
            
            Console.WriteLine("Elija un artefacto eléctrico");

            Artefacto artefacto1= new Artefacto();
            artefacto1.Nombre = "Refrigeradora";
            artefacto1.CantElectricidad = 600;

            Artefacto artefacto2 = new Artefacto();
            artefacto2.Nombre = "Microondas";
            artefacto2.CantElectricidad = 1200;

            Artefacto artefacto3 = new Artefacto();
            artefacto3.Nombre = "Batidora";
            artefacto3.CantElectricidad = 140;


            Console.WriteLine(artefacto1.Nombre);
            Console.WriteLine("Usa"+artefacto1.CantElectricidad.ToString());

            Console.WriteLine(artefacto2.Nombre);
            Console.WriteLine("Usa" + artefacto2.CantElectricidad.ToString());

            Console.WriteLine(artefacto3.Nombre);
            Console.WriteLine("Usa" + artefacto3.CantElectricidad.ToString());

        }

        public void ArtGas()
        {
            
            Console.WriteLine("Elija un artefacto a gas");

            Artefacto artefacto4 = new Artefacto();
            artefacto4.Nombre = "Cocina";
            artefacto4.CantGas = 120;

            Artefacto artefacto5 = new Artefacto();
            artefacto5.Nombre = "Horno";
            artefacto5.CantGas = 150;

            Console.WriteLine(artefacto4.Nombre);
            Console.WriteLine("Usa" + artefacto4.CantGas.ToString());

            Console.WriteLine(artefacto5.Nombre);
            Console.WriteLine("Usa" + artefacto5.CantGas.ToString());
        }

        
    }

   

    


}
