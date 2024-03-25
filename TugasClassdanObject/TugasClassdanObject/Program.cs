using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasClassdanObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Membuat object Taxi
            Taxi taxi = new Taxi();

            //Pengesetan nilau properti
            taxi.DriverName = "Jono";
            taxi.OnDrive = true;
            taxi.NumPassenger = 10;

            //Pemanggilan method
            taxi.TaxiInfo();  
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();
        }
    }
}
