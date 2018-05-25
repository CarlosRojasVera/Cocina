using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarlosRojas
{
    public class Cocina
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenivo a la cocina");
            Console.WriteLine("Vamos a cocinar un platillo");
            Console.WriteLine("Escoja un artefacto");

            Artefacto artefacto = new Artefacto();
            artefacto.ArtElectrico();
            Console.ReadLine();
            artefacto.ArtGas();
            Console.ReadLine();

            Contenedor contenedor = new Contenedor();
            contenedor.Contenedores();
            Console.ReadLine();

            Alimento alimento = new Alimento();
            alimento.AlimentoExpuestoAlAmbiente();
            Console.ReadLine();
            alimento.AlimentoRefrigerado();
            Console.ReadLine();
            alimento.AlimentoCongelado();
            Console.ReadLine();

            Material material = new Material();
            material.MaterialParaCocinarYPreparar();
            Console.ReadLine();
            material.MaterialParaServir();
            Console.ReadLine();
            material.MaterialDeAseo();
            Console.ReadLine();

            Console.WriteLine("..");
            Console.ReadLine();
        }
    }
}
