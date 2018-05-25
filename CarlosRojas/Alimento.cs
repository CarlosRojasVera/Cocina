using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarlosRojas
{
    public class Alimento
    {
        public string Nombre;
        public float Peso;
        public bool Usable;
        public float TiempoParaEstarFresco;
        public float TiempoDeDescongelado;

        public void AlimentoExpuestoAlAmbiente()
        {
            Console.WriteLine("Escoja un alimento");

            Alimento alimento1 = new Alimento();
            alimento1.Nombre = "Sal";
            alimento1.Peso = 170;
            alimento1.Usable = true;

            Alimento alimento2 = new Alimento();
            alimento2.Nombre = "Pimienta";
            alimento2.Peso = 170;
            alimento2.Usable = true;

            Alimento alimento3 = new Alimento();
            alimento3.Nombre = "Orégano";
            alimento3.Peso = 100;
            alimento3.Usable = true;

            Alimento alimento4 = new Alimento();
            alimento4.Nombre = "Agua";
            alimento4.Peso = 1000;
            alimento4.Usable = true;

            Alimento alimento5 = new Alimento();
            alimento5.Nombre = "Cereal";
            alimento5.Peso = 1000;
            alimento5.Usable = true;

            Alimento alimento6 = new Alimento();
            alimento6.Nombre = "Azucar";
            alimento6.Peso = 300;
            alimento6.Usable = true;

            Console.WriteLine(alimento1.Nombre);
            Console.WriteLine("Pesa " + alimento1.Peso.ToString());
            Console.WriteLine(alimento2.Nombre);
            Console.WriteLine("Pesa " + alimento2.Peso.ToString());
            Console.WriteLine(alimento3.Nombre);
            Console.WriteLine("Pesa " + alimento3.Peso.ToString());
            Console.WriteLine(alimento4.Nombre);
            Console.WriteLine("Pesa " + alimento4.Peso.ToString());
            Console.WriteLine(alimento5.Nombre);
            Console.WriteLine("Pesa " + alimento5.Peso.ToString());
            Console.WriteLine(alimento6.Nombre);
            Console.WriteLine("Pesa " + alimento6.Peso.ToString());



        }

        public void AlimentoRefrigerado ()
        {
            Console.WriteLine("Escoja otro alimento");

            Alimento alimento7 = new Alimento();
            alimento7.Nombre = "Huevo";
            alimento7.Peso = 30;
            alimento7.TiempoParaEstarFresco =30;

            Alimento alimento8 = new Alimento();
            alimento8.Nombre = "Mantequilla";
            alimento8.Peso = 30;
            alimento8.TiempoParaEstarFresco = 30;

            Alimento alimento9 = new Alimento();
            alimento9.Nombre = "Queso";
            alimento9.Peso = 500;
            alimento9.TiempoParaEstarFresco = 50;

            Alimento alimento10 = new Alimento();
            alimento10.Nombre = "Leche";
            alimento10.Peso = 400;
            alimento10.TiempoParaEstarFresco = 40;

            Alimento alimento11 = new Alimento();
            alimento11.Nombre = "Fruta";
            alimento11.Peso = 150;
            alimento11.TiempoParaEstarFresco = 30;

            Alimento alimento12 = new Alimento();
            alimento12.Nombre = "Verdura";
            alimento12.Peso = 150;
            alimento12.TiempoParaEstarFresco = 30;

            Console.WriteLine(alimento7.Nombre);
            Console.WriteLine("Pesa "+ alimento7.Peso.ToString());
            Console.WriteLine("Esta fresco en " + alimento7.TiempoParaEstarFresco.ToString());

            Console.WriteLine(alimento8.Nombre);
            Console.WriteLine("Pesa " + alimento8.Peso.ToString());
            Console.WriteLine("Esta fresco en " + alimento8.TiempoParaEstarFresco.ToString());

            Console.WriteLine(alimento9.Nombre);
            Console.WriteLine("Pesa " + alimento9.Peso.ToString());
            Console.WriteLine("Esta fresco en " + alimento9.TiempoParaEstarFresco.ToString());

            Console.WriteLine(alimento10.Nombre);
            Console.WriteLine("Pesa " + alimento10.Peso.ToString());
            Console.WriteLine("Esta fresco en " + alimento10.TiempoParaEstarFresco.ToString());

            Console.WriteLine(alimento11.Nombre);
            Console.WriteLine("Pesa " + alimento11.Peso.ToString());
            Console.WriteLine("Esta fresco en " + alimento11.TiempoParaEstarFresco.ToString());

            Console.WriteLine(alimento12.Nombre);
            Console.WriteLine("Pesa " + alimento12.Peso.ToString());
            Console.WriteLine("Esta fresco en " + alimento12.TiempoParaEstarFresco.ToString());

        }

        public void AlimentoCongelado()
        {
            Console.WriteLine("Escoja un último alimento");

            Alimento alimento13 = new Alimento();
            alimento13.Nombre = "Carne";
            alimento13.Peso = 1000;
            alimento13.TiempoDeDescongelado= 90;

            Alimento alimento14 = new Alimento();
            alimento14.Nombre = "Hielo";
            alimento14.Peso = 500;
            alimento14.TiempoDeDescongelado = 30;

            Console.WriteLine(alimento13.Nombre);
            Console.WriteLine("Pesa " + alimento13.Peso.ToString());
            Console.WriteLine("Se descongela en " +alimento13.TiempoDeDescongelado.ToString());

            Console.WriteLine(alimento14.Nombre);
            Console.WriteLine("Pesa " + alimento14.Peso.ToString());
            Console.WriteLine("Se descongela en " + alimento14.TiempoDeDescongelado.ToString());

        }

    }
}
