using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HGS.Models
{
    class Vehicle
    {
        public int id { get; set; }
        public int hgsNo { get; set; }
        public string ownerFirstname { get; set; }
        public string ownerLastName { get; set; }
        public string typeOfVehicle { get; set; }
        public DateTime date { get; set; }
        public int balance { get; set; }



    }
}
