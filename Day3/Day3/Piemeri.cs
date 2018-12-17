using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Piemeri
    {
        public void MasivaPirmaisPiemers()
        {
            //int skaitlis = 4;

            String[] zvaigzne = new String[4];
            //masivs[0] = 1;
            //masivs[1] = 4;
            //masivs[2] = 5;
            // int garums = masivs.Length;

            for (int i = 0; i < zvaigzne.Length; i++)
            {
                if (i == 0)
                {
                    zvaigzne[i] = "*";
                }
                else
                {
                    zvaigzne[i] = zvaigzne[i - 1] + "*";
                }

                Console.WriteLine(zvaigzne[i]);
            }


            for(int i = zvaigzne.Length-1; i>=0; i--)
            {
                Console.WriteLine(zvaigzne[i]);
            }

            //// MASIVA UZDEVUMS
            ///ar 4.punktiem
           
        }
        public void MasivaIevade()
        {
            Console.WriteLine(" Ievadiet masiva garumu");
            int garums = Convert.ToInt16(Console.ReadLine());

            String[] masivs = new String[garums]; // 2.punkts

            for (int i = 0; i < masivs.Length; i++)
            {
                Console.WriteLine("Ievadiet masiva" + i + "." + " elementu");
                masivs[i] = Console.ReadLine();
            }

            Console.WriteLine("------------------");

            for (int i = 0; i < masivs.Length; i++ )
            {
                Console.WriteLine(masivs[i]);
            }
        }
            
    }


       

    }
