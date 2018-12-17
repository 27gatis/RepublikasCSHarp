using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajasdarbsDay2
{
    class Program
    {
        static void Main(string[] args)
        {
            MajasdarbsDay2Uzdevums md2 = new MajasdarbsDay2Uzdevums();
            int skaitlis1 = IevaditSkaitli("Ievadit pirmo skaitli"); // parveido simbolu uz skaitli
            int skaitlis2 = IevaditSkaitli("Ievadit otro skaitli");
            

            //int result = SaskaititVaiAtnemt(skaitlis1, skaitlis2);
            Console.WriteLine(md2.SaskaititVaiAtnemt(skaitlis1, skaitlis2));
            Console.ReadLine();

            //MajasdarbsDay2Uzdevums uzd = new MajasdarbsDay2Uzdevums();
            //Console.WriteLine(uzd.Kapinat(skaitlis1, skaitlis2));

            //Console.ReadLine();

        }

        /* static int SaskaititVaiAtnemt(int a, int b)
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
        */

            static int IevaditSkaitli(String izvadamaZina)
            {
            Console.WriteLine(izvadamaZina);
            String ievade = Console.ReadLine();

            return Convert.ToInt16(ievade);

            }

        

    }
}
