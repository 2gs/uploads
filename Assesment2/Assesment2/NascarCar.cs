using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment2
{
    class NascarCar: Car
    {
        private string teamName;

        public string Teamname
        {
            set{ teamName = value; }
           get { return teamName; }
        }

        public NascarCar()
        {
            this.teamName = " ";
            this.Vin = "";
            this.Make = "";

        }
        public NascarCar(string teamName, string vin,string make)
        {
            this.teamName = teamName;
            this.Vin = vin;
            this.Make = make;
        }

        public override void PrintInfo() {
        Console.WriteLine("This is the nascar's vin" + Vin + " " + "This is the Nascar's make" + Make + "This is the NasCar's Team Name:" + " " + teamName );
        }

        public override string ToString()
        {
            return ("This is the nascar's vin" + Vin + " " + "This is the Nascar's make" + Make + "This is the NasCar's Team Name:" + " " + teamName);

        }
    }
}
