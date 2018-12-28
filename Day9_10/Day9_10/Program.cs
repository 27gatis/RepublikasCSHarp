using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzdevumi
{
    class Program
    {
        static void Main(string[] args)
        {
            //SarakstaUzdevumi sarakstaUzdevumi = new SarakstaUzdevumi();
            //FailaRakstisanasPiemers failaRakstisanasPiemers = new FailaRakstisanasPiemers();
            //Uzdevumi uzd = new Uzdevumi();

            //sarakstaUzdevumi.Interfeiss();
            //sarakstaUzdevumi.PievienotNumuru();
            //sarakstaUzdevumi.PievienotSarakstam();
            //sarakstaUzdevumi.Search();
            //sarakstaUzdevumi.Izdzest();

            //failaRakstisanasPiemers.LasitSaskaitit();

            //uzd.DzejolisNolasit();
            //Console.ReadLine();

           // SarakstaPiemeri sar = new SarakstaPiemeri();
           // sar.SarakstaPiemers();



            Uzdevums uzd = new Uzdevums();
            uzd.Menu();

            Console.ReadLine();
        }
    }
}