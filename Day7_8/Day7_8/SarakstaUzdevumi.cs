using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_8
{
    class SarakstaUzdevumi
    {
        List<String> lietotaji = new List<String>();
       // List<int> lietotajuNumuri = new List<int>();
        public void IzvaditLietotajuSaraksts()
        {
            //String list 
            //prasam, lai cilveks ievada lietotaja vardu, ko pievienot sarakstam
            //izvelnei(while{switch, case)
            //1.pievienot jaunu lietotaju sarakstam
            //2.izvadit sarakstu
            //ja saraksts ir tukss, tad pie izvelnes tas ir japasaka

            String choice = "";

            while (true)
            {
                Console.WriteLine("Izvelies darbibu - 1 (lai pievienotu lietotaju) vai 2 (lai izvaditu sarakstu),  vai iziet (lai izietu)");
                choice = Console.ReadLine();
                if (choice == "iziet")
                {
                    break;
                }


                // int skaitlis2 = Ievade("Ievadiet otro skaitli");

                switch (choice)
                {
                    case "1":

                        // List<int> pirmaisSaraksts = new List<int>();
                        Console.WriteLine("Ievadiet lietotaja vardu");
                        String lietotajaVards = Console.ReadLine();
                        lietotaji.Add(lietotajaVards);

                        break;
                    case "2":

                        for (int i = 0; i < lietotaji.Count; i++)
                        {
                            Console.WriteLine(lietotaji[i]);
                        }
                        if (lietotaji.Count == 0) // parada, ka saraksts ir tukss
                        {
                            Console.WriteLine("Saraksts ir tukss!");
                        }

                        break;

                    default:
                        Console.WriteLine("Nepareiza ievade");
                        break;
                }
                    
                

            }
            


        }


        public void PievienotSarakstam()
        {

        }



}
}
