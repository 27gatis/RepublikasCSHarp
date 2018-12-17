using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajasdarbsDay2
{
    class MajasdarbsDay2Uzdevums
    {
        public int Kapinat(int baze, int pakape) // var nemt ara, jo leja jau ir
        {
            int result = 1;
            for (int i = 0; i < pakape; i++)
            {
                result = result * baze;

            }
            return Convert.ToInt16(result);
            // komandrindas kalkulators, 
            // ar switch, case
            // while // jauna projekta
        }

        public int SaskaititVaiAtnemt(int a, int b)
        {
            Console.WriteLine("Izvelies darbibu: ");
            Console.WriteLine("1.Saskaitit (spied +)  2.Atnemt(spied -)  3.Kapinat(spied k)");
            String izvele = Console.ReadLine();
            if (izvele == "+")
            {
                return a + b;
            }
            else if (izvele == "-")
            {
                return a - b;
            }
            else if (izvele == "k")
            {
                int result = 1;
                for (int i = 0; i < b; i++)
                {
                    result *= a;

                }
                return Convert.ToInt16(result);
            }
            else
            {
                return -9999;
            }

        }
    }
}
