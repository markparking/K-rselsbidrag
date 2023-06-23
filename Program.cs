using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kørselsbidrag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logic logic = new Logic();
            Console.WriteLine("Km per dag:");
            logic.kmPerDag = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("[0] Ingen bro\n[1] Øresund\n[2] Storebelt");
            logic.broType = Convert.ToInt32(Console.ReadLine());
            logic.Output();
                Console.ReadKey();
        }

    }
}
