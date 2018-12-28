using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzdevumi
{
    class Uzdevums
    {
        private List<String> joki = new List<String>();

        public void Menu()
        {
            String choice = "";
            while (choice != "0")
            {

                Console.WriteLine("1. - izvadit visus jokus");
                Console.WriteLine("2. - izvadit konkretu joku");
                Console.WriteLine("3. - Pievienot sarakstam");
                Console.WriteLine("4. - Random joks");
                Console.WriteLine("0. - iziet");

                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        IzvaditVisus();
                        break;

                    case "2":
                        IzvaditKonkretu();
                        break;

                    case "3":
                        break;

                    case "4":
                        break;

                    case "0":
                        break;
                    default:
                        Console.WriteLine("Nepareiza ievade");
                        break;
                }
            }


        }

        public void IzvaditVisus()
        {
            String[] joki = System.IO.File.ReadAllLines(@"D:\VisualPiemeri\joki.txt"); // nolasa

            for (int i = 0; i < joki.Length; i++) // izvada
            {
                Console.WriteLine(joki[i]);
            }

            Console.WriteLine();
        }


        public void IzvaditKonkretu()
        {
            Console.WriteLine("Ievadi indeksu!");
            String[] joki = System.IO.File.ReadAllLines(@"D:\VisualPiemeri\joki.txt"); // nolasa
            int jokaNr = Convert.ToInt16(Console.ReadLine());
            bool skaitlisAtrasts = false;

            for (int i = 0; i < joki.Length; i++) // izvada
            {
                if (jokaNr == i + 1)
                {
                    Console.WriteLine("joks ir - " + joki [i]);
                    skaitlisAtrasts = true;
                }
            }

            if (!skaitlisAtrasts) //(skaitlisAtrasts==false)
            {
                Console.WriteLine("Tada joka nav");
            }
        }

        public void Pievienosana()
        {

        }

        
        }
    }
   