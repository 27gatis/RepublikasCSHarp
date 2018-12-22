using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_8
{
    class SarakstaUzdevumi
    {
        private List<String> lietotaji = new List<String>();
        private List<int> lietotajuNumuri = new List<int>();
        private void IzvaditLietotajuSarakstu()
        {
            //String list
            //prasam, lai cilveks ievada lietotaja vardu ko pievienot sarakstam
            //izvelnei (while{switch,case)
            //1. pievienot jaunu lietotaju sarakstam
            //2. izvadit sarakstu
            //ja saraksts ir tukss, tad pie izvades tas ir japasaka
            if (lietotaji.Count == 0)
            {
                Console.WriteLine("Saraksts ir tukss");
            }
            else
            {
                for (int i = 0; i < lietotaji.Count; i++)
                {
                    Console.WriteLine(lietotajuNumuri[i] + "." + lietotaji[i]);
                }
            }

        }

        private void PievienotSarakstam()
        {
            Console.WriteLine("Ievadet lietotajvardu!");
            lietotaji.Add(Console.ReadLine());

            if (lietotajuNumuri.Count == 0)
            {
                lietotajuNumuri.Add(1);
            }
            else
            {
                lietotajuNumuri.Add(lietotajuNumuri[lietotajuNumuri.Count - 1] + 1);
            }


        }

        private void Search()
        {
            //pieskirt otra saraksta katram lietotajam numuru

            //lietotajs ievada ID un tad pec ta mes ari atrodam lietotajvardu
            //izvadam lietotajvardu + ID
            // ja nav nekas attrasts , tad pazinojam
            // ievada id - ar for ciklu ejam cauri id sarakstam
            //no ta varam dabut i (indeksu), int atrastsaisSkaitlis = i;

            //so indeksu varam izmantot, lai izvaditu Console.writeline(lietotaji[atrastaisSkaitlis])


            Console.WriteLine("Ievadiet ID");
            int id = Convert.ToInt16(Console.ReadLine());

            bool skaitlisAtrasts = false;

            for (int i = 0; i < lietotaji.Count; i++)
            {
                if (id == lietotajuNumuri[i])
                {
                    Console.WriteLine(lietotajuNumuri[i] + "." + lietotaji[i]);
                    skaitlisAtrasts = true;
                }
            }

            if (!skaitlisAtrasts) //(skaitlisAtrasts==false)
            {
                Console.WriteLine("ID netika atrasts");
            }
        }





        public void Interfeiss()
        {
            String choice = "";
            while (choice != "0")
            {
                Console.WriteLine("1, lai pievienotu, 2, lai izvaditu sarakstu,vai 7 (lai atrastu ID) 0, lai izietu");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        PievienotSarakstam();
                        break;
                    case "2":
                        IzvaditLietotajuSarakstu();
                        break;
                    case "7":
                        Search();
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Nepareiza ievade");
                        break;
                }

            }
        }
    }
}
