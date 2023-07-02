using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            clsDPilaS pilaPrueba = new clsDPilaS();

            
            pilaPrueba.Add(0,5);
            pilaPrueba.Add(0, 23);
            pilaPrueba.Add(1, 28);
            pilaPrueba.Add(2, 12);
            Console.WriteLine("Cuestionario T6 ");
            Console.WriteLine(pilaPrueba.Mostrar());
            Console.ReadKey();

        }
    }
}
