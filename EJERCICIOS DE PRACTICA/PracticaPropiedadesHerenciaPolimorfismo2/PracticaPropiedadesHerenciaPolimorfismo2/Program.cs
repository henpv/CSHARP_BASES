using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPropiedadesHerenciaPolimorfismo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Figura> listFig = new List<Figura>();

            listFig.Add(new Circulo("Circulo1","Azul",5));
            listFig.Add(new Rectangulo("Rectangulo1","Verde",10,10));
            listFig.Add(new Triangulo("Rectangulo1","Rojo",5,6,8));


            /* //Casteo usando "as"
            if (listFig[2] is Triangulo tc)
            {
                Console.WriteLine("LadoA: {0}",tc.LadoA);
                Console.WriteLine("LadoB: {0}",tc.LadoB);
                Console.WriteLine("LadoC: {0}",tc.LadoC);
            }*/


            foreach (Figura fig in listFig)
            {
                Console.WriteLine("================================================================");
                Console.WriteLine("Nombre: {0}", fig.Nombre);
                Console.WriteLine("Color: {0}", fig.Color);
                Console.WriteLine("Tipo: {0}", fig.Tipo);
                Console.WriteLine("Area: {0}", fig.CalcularArea());
                Console.WriteLine("Perimetro: {0}", fig.CalcularPerimetro());
                Console.WriteLine("================================================================");
                Console.WriteLine();

            }

        }
    }
}
