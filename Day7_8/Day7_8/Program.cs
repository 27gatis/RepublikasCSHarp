using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_8
{
    class Program
    {
        static void Main(string[] args)
        {

            SarakstaUzdevumi uzd = new SarakstaUzdevumi();
            //uzd.Interfeiss();

            FailaRakstisanasPiemers fails = new FailaRakstisanasPiemers();
            fails.Rakstit();


        }
    }
}
