using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HGS.Models
{
    public class DailyEarning
    {
        int toplamKazanc=0;

        public void kazanc(Int64 hgsNo)
        {
            if(hgsNo == 1212121212)
            {
                toplamKazanc += 50;
            }
            else if(hgsNo == 1313131313)
            {
                toplamKazanc += 70;
            }
            else if (hgsNo == 1414141414)
            {
                toplamKazanc += 100;
            }
        }

        public void kazanciYazdir()
        {
            Console.WriteLine("Günlük toplam kazanç: " + toplamKazanc);
        }



    }
}
