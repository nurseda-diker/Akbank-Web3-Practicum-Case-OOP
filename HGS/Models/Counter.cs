using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HGS.Models
{
    public class Counter
    {
        public int carPay = 50;
        public int minibusPay = 70;
        public int busPay = 100;

        public int carBalance = 1500;
        public int minibusBalance = 2500;
        public int busBalance = 3500;

        ArrayList vehicles = new ArrayList();


        public void Payment(Int64 hgsNo)
        {
            Vehicle car = new Vehicle();
            Vehicle minibus = new Vehicle();
            Vehicle bus = new Vehicle();

            car.balance = carBalance;
            minibus.balance = minibusBalance;
            bus.balance = busBalance;

            if(hgsNo == 1212121212)
            {
                carBalance -= carPay;
                car.balance = carBalance;
                Console.WriteLine("Arabanın geçiş yaptığı tarih ve saat: " + DateTime.Now + " ve güncel bakiye: " + car.balance);
            }
            else if (hgsNo == 1313131313)
            {
                minibusBalance -= minibusPay;
                minibus.balance = minibusBalance;
                Console.WriteLine("Minibüsün geçiş yaptığı tarih ve saat: " + DateTime.Now + " ve güncel bakiye: " + minibus.balance);
            }
            else if(hgsNo == 1414141414)
            {
                busBalance -= busPay;
                bus.balance = busBalance;
                Console.WriteLine("Otobüsün geçiş yaptığı tarih ve saat: " + DateTime.Now + " ve güncel bakiye: " + bus.balance);
            }
           

            vehicles.Add(hgsNo);






        }


    }
}
