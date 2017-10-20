using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myList = new List<Car>();
              
            for(int i = 1; i <= 6; i++)
            {
                myList.Add(new NascarCar("Dogders", "45678", "Ford"));
                myList.Add(new NascarCar("HustleHard", "45678", "Mercedes"));
                myList.Add(new NascarCar("NoLuck", "45678", "GM"));
                myList.Add(new NascarCar("Lucky", "45678", "Dodge"));
                myList.Add(new Car("456789", "Ford"));
                myList.Add(new Car("78909", "Mercedes"));
            }


            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i].ToString());
            }
        }
    }
}
