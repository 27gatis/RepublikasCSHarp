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
        private List<String> lietotajuNumuri = new List<String>();

        public void Menu()
        {

            String choice = "";
            while (choice != "0")
            {

                Console.WriteLine("1.- Izvadit visus lietotajus");
                Console.WriteLine("2.- Izvadit konkretu lietotaju");
                Console.WriteLine("3.- Pievienot sarakstam");
                Console.WriteLine("4.- Izdzest lietotaju");
                Console.WriteLine("5.- Iztirit failu");
                Console.WriteLine("6.- Ierakstit sarakstu faila");
                Console.WriteLine("9.- Izvadit Random lietotaju");
                Console.WriteLine("0.- Iziet");

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
                        Pievienot(); // numuri dublejas(pievieno lietotaju, bet nepievieno numuru otra faila, tikai vardu)
                        break;
                    
                    case "4":
                        IzdzestLietotaju(); //Nestrada
                        break;
                    case "5":
                        DzestVisusLietotajus(); //Strada
                        break;
                    case "6":
                        RakstisanaJaunaFaila fails = new RakstisanaJaunaFaila(); // Strada
                        fails.Rakstit(lietotaji);
                        break;
                    case "9":
                        RandomLietotajs(); // Strada
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
            Console.WriteLine("Ievadiet indeksu:");
            int lietotajaNr = Convert.ToInt32(Console.ReadLine());

            if (lietotajaNr > 0 && lietotajaNr <= lietotaji.Count)
            {
                Console.WriteLine(lietotaji[lietotajaNr - 1]); // i - 1, jo sak skaitit no 0
            }
            else
            {
                Console.WriteLine("Lietotajs Neeksiste");
            }

        }


        private void Pievienot()
        {
            RefreshLietotaji();
            Console.WriteLine("Ievadi jauno lietotaju:");
            String teksts = Console.ReadLine();
            //int numurs = Convert.ToInt32(Console.ReadLine());

            if (teksts != "")
            {
                lietotaji.Add(teksts);
                lietotajuNumuri.Add(teksts); // raksta otra(ID) faila vardus
            }
            else
            {
                Console.WriteLine("Nepareiza Ievade!");
                return;
            }


            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"D:\VisualPiemeri\lietotaji.txt"))
            {
                foreach (String lietotajs in lietotaji)
                {
                    file.WriteLine(lietotajs); //rada ciparu divreiz

                }

            }

            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"D:\VisualPiemeri\lietotajunumuri.txt"))
            {
                foreach (String lietotajanumurs in lietotajuNumuri)
                {
                    file.WriteLine(lietotajanumurs); //rakstisana 2.faila - raksta tikai vardu (Bet nepieciesams lai raksta ID)

                }

            }

        }



        private void IzdzestLietotaju()
        {
            Console.WriteLine("Ievadiet lietotaja ID:");
            //int id = Convert.ToInt16(Console.ReadLine());
            string id = Console.ReadLine();

            bool atrasts = false;
            for (int i = 0; i < lietotaji.Count; i++)
            {
                if (lietotajuNumuri.Contains(id))
                {
                    //Console.WriteLine
                    lietotaji.RemoveAt(i);
                    lietotajuNumuri.RemoveAt(i);
                    Console.WriteLine("Ieraksts dzests");
                    atrasts = true;
                    break;
                }
            }

            if (atrasts != true)
            {
                Console.WriteLine("ID netika atrast");
            }
        }

        
        private void DzestVisusLietotajus()
        {
            lietotaji.Clear();
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"D:\VisualPiemeri\lietotaji.txt"))
            {
                file.Write("");
            }

            lietotajuNumuri.Clear();
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"D:\VisualPiemeri\lietotajuNumuri.txt"))
            {
                file.Write("");
            }
        }

        private void RandomLietotajs()
        {
            Random rnd = new Random();
            int lietotajaNr = rnd.Next(lietotaji.Count);
            Console.WriteLine(lietotaji[lietotajaNr]);
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
                    lietotajuNumuri.Add(lines2[i]);
                }

            }
            

        }




    }
}
