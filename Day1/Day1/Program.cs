using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {

            // PirmaisUzdevums();
            /*Console.WriteLine(Piemers());
            int a = Piemers();
            Console.ReadLine();

            Console.WriteLine(Piemers2(3, a));
            Console.ReadLine(); */


            // Uzdevums - saskaitisana un atnemsana
            
            int skaitlis1 = IevaditSkaitli("Ievadit pirmo skaitli"); // parveido simbolu uz skaitli
            int skaitlis2 = IevaditSkaitli("Ievadit otro skaitli");


            ///////////////
            int result = SaskaititVaiAtnemt(skaitlis1, skaitlis2);
            Console.WriteLine(result);
            Console.ReadLine();
                
        }

        static void PirmaisUzdevums()
        {
            Console.WriteLine("Ka jus sauc?");

            String vards = Console.ReadLine();

            Console.WriteLine("Sveiki, " + vards);


        }

        static int Piemers()
        {
            return 4 + 3;
        }

        static int Piemers2(int a, int b)
        {
            return a + b;
        }

        static void Piemers3()
        {
            Console.WriteLine("Ievadiet simbolus!");
            String ievade = Console.ReadLine();
            int a = 5;
            if (ievade == "vii" && a > 5)
            {
                Console.WriteLine("1");
            }
            else if (ievade == "vii" && a == 5)
            {
                Console.WriteLine("2");
            }
            else
            {

            }
            //<
            //>
            //<=, >=, ==(salidzina), = (pielidzina)
            //!=

            //&& AND
            //|| OR
        }
        // funkcija, kas lauj cilvekam izveleties vai saskaita vai atnem
        // jabut return, gan parametriem

        static int SaskaititVaiAtnemt(int a, int b)
        {
            Console.WriteLine("Saskaitit vai atnemt?");
            String izvele = Console.ReadLine();
            if (izvele == "+")
            {
                return a + b;
            }
            else if(izvele == "-")
            {
                return a - b;
            }
            else
            {
                return -9999;
            }
        
        }

        static int IevaditSkaitli(String izvadamaZina)
        {
            Console.WriteLine(izvadamaZina);
            String ievade = Console.ReadLine();

            return Convert.ToInt16(ievade);

        }
    }
}
