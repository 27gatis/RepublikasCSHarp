using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2___istais_fails
{
    class Program
    {
        static void Main(string[] args)
        {
            //Piemers piem = new Piemers();
            // piem.TestaIzvade();

            //Piemers.TestaIzvade2();

            // Console.ReadLine();

            //  Uzdevums.Zvaigzne(); 
            //  Console.ReadLine();
            Uzdevums uzd = new Uzdevums();
            Console.WriteLine(uzd.Kapinat(5, 3));
            
            Console.ReadLine();
        }
    }
}
