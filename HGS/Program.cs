using HGS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HGS
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Int64 hgsNo = 0;
            Counter gise = new Counter();
            DailyEarning earn = new DailyEarning();
            Vehicle car = new Vehicle();
            Vehicle minibus = new Vehicle();
            Vehicle bus = new Vehicle();

            car.hgsNo = 1212121212;
            car.ownerFirstname = "Ross";
            car.ownerLastName = "Geller";
            car.typeOfVehicle = "Car";

            minibus.hgsNo = 1313131313;
            minibus.ownerFirstname = "Phoebe";
            minibus.ownerLastName = "Buffay";
            minibus.typeOfVehicle = "Minibus";

            bus.hgsNo = 1414141414;
            bus.ownerFirstname = "Chandler";
            bus.ownerLastName = "Bing";
            bus.typeOfVehicle = "Bus";

            
            

            while (true)
            {
                Console.WriteLine("Geçecek olan aracın sınıfını seçiniz:");
                Console.WriteLine("1-Otomobil \n2-Minibüs \n3-Otobüs \n4-Günlük Kazancı Yazdır");

                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Araç sahibi:" + car.ownerFirstname + " " + car.ownerLastName);
                        Console.WriteLine("Seçtiğiniz araç sınıfı otomobil ve hgs numarası: " + car.hgsNo);
                        hgsNo = car.hgsNo;
                        gise.Payment(hgsNo);
                        earn.kazanc(hgsNo);
                        break;
                    case 2:
                        Console.WriteLine("Araç sahibi:" + minibus.ownerFirstname + " " + minibus.ownerLastName);
                        Console.WriteLine("Seçtiğiniz araç sınıfı minibüs ve hgs numarası: " + minibus.hgsNo);
                        hgsNo = minibus.hgsNo;
                        gise.Payment(hgsNo);
                        earn.kazanc(hgsNo);
                        break;
                    case 3:
                        Console.WriteLine("Araç sahibi:" + bus.ownerFirstname + " " + bus.ownerLastName);
                        Console.WriteLine("Seçtiğiniz araç sınıfı otobüs ve hgs numarası: " + bus.hgsNo);
                        hgsNo = bus.hgsNo;
                        gise.Payment(hgsNo);
                        earn.kazanc(hgsNo);
                        break;
                    case 4:
                        earn.kazanciYazdir();
                        hgsNo = 0;
                        break;
                }
            }




        }
    }
}
