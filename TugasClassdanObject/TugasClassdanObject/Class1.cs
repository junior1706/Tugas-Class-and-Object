using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasClassdanObject
{
    public class Taxi
    {
        public string DriverName { get; set; }
        public bool OnDrive {  get; set; }
        public int NumPassenger { get; set; }

    

    public void TaxiInfo()
    {
        Console.WriteLine("Nama Driver : {0}", DriverName);
        Console.WriteLine("On Duty : {0}", OnDrive);
        Console.WriteLine("Number of Passenger : {0}", NumPassenger);
        Console.WriteLine();
    }
        public void PickUpPassenger()
        {
            Console.WriteLine("{0} sedang menjemput", DriverName);
            Console.WriteLine();
        }
        public void DropOffPassenger()
        {
            Console.WriteLine("{0} penumpang telah diturunkan", DriverName);
            Console.ReadKey();
        }
    }
}
