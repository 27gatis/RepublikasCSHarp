using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2___istais_fails
{
    class Piemers
    {
        public Piemers() /////konstruktors 
        {

        }

        public void TestaIzvade()
        {
            Console.WriteLine("vii");
        }

        public static void TestaIzvade2()
        {
            Console.WriteLine("vii2");
        }
        
        public void Cikli()
        {
            //while,do..while, for

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("vii");
            }

            String izvele = "";

            while (izvele!="iziet")
            {
                Console.WriteLine("Vai gribat iziet?");
                izvele = Console.ReadLine();
            }

            do
            {
                Console.WriteLine("Vai gribat iziet?");
                Console.ReadLine();
            } while (izvele !="iziet");

        }
    }
}
