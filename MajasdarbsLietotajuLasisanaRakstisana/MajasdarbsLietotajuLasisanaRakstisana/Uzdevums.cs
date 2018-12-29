using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajasdarbsLietotajuLasisanaRakstisana
{
    class Uzdevums
    {
        // 1.Lasit visus lietotajus
        //2.Lasit konkretu lietotaju
        //3.Pievienot jaunu lietotaju
        //4. Izdzest konkretu lietotaju
        //5.Izdzest visus lietotajus
        //6. Ierakstit sarakstu faila
        //0.Iziet

        private List<String> lietotaji = new List<String>();
        private List<int> lietotajuNumuri = new List<int>();

        public void Menu()
        {

            String choice = "";
            while (choice != "0")
            {

                Console.WriteLine("1.- Izvadit visus lietotajus");
                Console.WriteLine("2.- Izvadit konkretu lietotaju");
                Console.WriteLine("3.- Pievienot sarakstam");
                Console.WriteLine("4.- Random lietotajs");
                Console.WriteLine("5.- iztirit failu");
                Console.WriteLine("0. - iziet");

                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        IzvaditVisus(); // strada, bet neizmanto numuru failu
                        break;
                    case "2":
                        IzvaditKonkretu();// strada, bet neizmanto numuru failu
                        break;
                    case "3":
                        //Pievienot();
                        break;
                    case "4":
                        //RandomJoks();
                        break;
                    case "5":
                        //Tirit();
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
            RefreshLietotaji();
            foreach (String lietotajs in lietotaji)
            {
                Console.WriteLine(lietotajs);
            }
        }


        private void IzvaditKonkretu()
        {
            RefreshLietotaji();
            Console.WriteLine("Ievadiet indeksu!");
            int lietotajaNr = Convert.ToInt32(Console.ReadLine());

            if (lietotajaNr > 0 && lietotajaNr <= lietotaji.Count)
            {
                Console.WriteLine(lietotaji[lietotajaNr - 1]); // i - 1, jo sak skaitit no 0
            }
            else
            {
                Console.WriteLine("Nepareiza ievade");
            }

        }



        private void RefreshLietotaji()
        {
            lietotaji.Clear();
            lietotajuNumuri.Clear();
            string[] lines = System.IO.File.ReadAllLines(@"D:\VisualPiemeri\lietotaji.txt");
            string[] lines2 = System.IO.File.ReadAllLines(@"D:\VisualPiemeri\lietotajunumuri.txt");


            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i] != "")
                {
                    lietotaji.Add((i + 1) + "." + lines[i]);
                }

            }

            for (int i = 0; i < lines2.Length; i++)
            {
                if (lines2[i] != "")
                {
                    lietotajuNumuri.Add(Convert.ToInt32(lines2[i]));
                }

            }


        }




    }
}
