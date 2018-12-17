using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ievadiet vertibu");
            Console.ReadLine();
            Piemeri piem = new Piemeri();
            piem.MasivaPirmaisPiemers();
            Console.ReadLine();
        }

        
    }
}
