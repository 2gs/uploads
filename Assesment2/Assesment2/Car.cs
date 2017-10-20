using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment2
{
    class Car
    {
        private string vin;
        private string make;

        public string Vin
        {
            set{ vin = value; }
            get{ return vin; }
        }
        public string Make
        {
            set{ make = value; }
            get{ return make; }
        }
        public Car()
        {
            this.vin = "";
            this.make = "";
        }
        public Car(string vin, string make)
        {
            this.vin = vin;
            this.make = make;
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine("This is the car make: " + " " + vin + " " + "This is the make " + "  "  + make);
        }
    }
}

