using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quel est le rayon r ?");
            double r = double.Parse(Console.ReadLine());

            double pi = Math.PI;
            double perimetre = 2 * pi * r;
            double surface = Math.Pow(r, 2) * pi;

            Console.WriteLine("Le périmetre est " + perimetre);
            Console.WriteLine("La surface est " + surface);

        }
    }
}
