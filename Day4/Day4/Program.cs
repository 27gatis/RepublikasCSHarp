using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Uzdevumi uzd = new Uzdevumi();
             uzd.PirmaisUzd();
             Console.ReadLine();

             Uzdevumi uzd2 = new Uzdevumi();
             uzd2.OtraisUzd();
             Console.ReadLine();

             Uzdevumi uzd3 = new Uzdevumi();
             uzd3.Meklesana();
             Console.ReadLine();

             Uzdevumi uzd4 = new Uzdevumi();
             uzd4.PirmaisMajasdarbs();
             Console.ReadLine(); 
             */

            // otrais majasdarbs
            Uzdevumi uzd = new Uzdevumi();
            uzd.OtraisMajasdarbs();
            Console.ReadLine();
        }
    }

}