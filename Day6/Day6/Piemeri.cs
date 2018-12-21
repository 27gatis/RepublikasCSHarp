using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class Piemeri
    {
        public void Koordinatas()
        {
            // String tipa 2D masivs
            /*
             1 1 1 
             2 2 2
             3 3 3  
             */


            String[,] parastsMAsivs = new string[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    parastsMAsivs[i, j] = Convert.ToString(i + 1); // +1 jo vajag 1,2,3(nevis 0,1,2), konverte uz no int uz string
                    Console.Write(parastsMAsivs[i, j] + " ");
                }
                Console.WriteLine();


            }
        }

        public void SkaitluMasivs()
        {
            //int tipa 2d masivs
            // cilvekam skaitli ir jaievada
            // pec tam masivu izvadam
            // ievadiet masiva vertibu (i,j) 
            // ja skaitlis ir lielaks par 5, aizstajam skaitli ar 6 un ja skaitlis ir mazaks par 5 tad aizstaj ar 4

            int[,] parastsMasivs = new int[3, 3];

            for (int i = 0; i < 3; i++) //ievade
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Ievadiet vertibu (" + i + "," + j + ")");
                    parastsMasivs[i, j] = Convert.ToInt16(Console.ReadLine()); // pieprasam lietotajam skaitli
                }
            }

            for (int i = 0; i < 3; i++) //izvade
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(parastsMasivs[i, j] + " ");
                }
                Console.WriteLine();

            }
            Console.WriteLine();


            for (int i = 0; i < 3; i++) //izvade izmainitajam masivam
            {
                for (int j = 0; j < 3; j++)
                {
                    if (parastsMasivs[i, j] > 5)
                    {
                        parastsMasivs[i, j] = 6;
                    }

                    if (parastsMasivs[i, j] <= 5)
                    {
                        parastsMasivs[i, j] = 4;
                    }
                    Console.Write(parastsMasivs[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
