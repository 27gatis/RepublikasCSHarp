using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzdevumi
{
    class Uzdevums
    {
        List<String> joki = new List<String>();
        public void Menu()
        {

            String choice = "";
            while (choice != "0")
            {

                Console.WriteLine("1.- Izvadit visus jokus");
                Console.WriteLine("2.- Izvadit konkretu joku");
                Console.WriteLine("3.- Pievienot sarakstam");
                Console.WriteLine("4.- Random joks");
                Console.WriteLine("5.- iztirit failu");
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
                        Pievienot();
                        break;
                    case "4":
                        RandomJoks();
                        break;
                    case "5":
                        Tirit();
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Nepareiza ievade");
                        break;
                }

            }
        }

        private void IzvaditVisus()
        {
            RefreshJoki();
            foreach (String joks in joki)
            {
                Console.WriteLine(joks);
            }
        }

        private void IzvaditKonkretu()
        {
            RefreshJoki();
            Console.WriteLine("Ievadiet indeksu!");
            int jokaNr = Convert.ToInt32(Console.ReadLine());

            if (jokaNr > 0 && jokaNr <= joki.Count)
            {
                Console.WriteLine(joki[jokaNr - 1]);
            }
            else
            {
                Console.WriteLine("Nepareiza ievade");
            }

        }

        private void Pievienot()
        {
            RefreshJoki();
            Console.WriteLine("Ievadiet joku!");
            String teksts = Console.ReadLine();

            if (teksts != "")
            {
                joki.Add(teksts);
            }
            else
            {
                Console.WriteLine("Nepareiza ievade");
                return;
            }


            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"D:\VisualPiemeri\joki.txt"))
            {
                foreach (string joks in joki)
                {
                    file.WriteLine(joks);
                }
            }
        }

        private void RandomJoks()
        {
            Random rnd = new Random();
            int jokaNr = rnd.Next(joki.Count);
            Console.WriteLine(joki[jokaNr]);
        }

        private void Tirit()
        {
            joki.Clear();
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"D:\VisualPiemeri\joki.txt"))
            {
                file.Write("");
            }
        }
        private void RefreshJoki()
        {
            joki.Clear();
            string[] lines = System.IO.File.ReadAllLines(@"D:\VisualPiemeri\joki.txt");

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i] != "")
                {
                    joki.Add(lines[i]);
                }

            }
        }
    }
}




