using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber2
{
    class Program
    {
        static void Main(string[] args)
        {
            string n, choice;
            int num;
            bool keep = true;

            while (keep)
            {


                Console.WriteLine("Enter in a number between 1 and 100");
                n = Console.ReadLine();

                num = int.Parse(n);

                if (num % 2 != 0)
                {
                    Console.WriteLine(num + " " + "is odd");
                    Console.WriteLine("Do  you want to continute Y or N");
                    choice = Console.ReadLine().ToUpper();

                    if (choice == "Y")
                    {
                        keep = true;
                    }
                    else if (choice == "N")
                    {
                        keep = false;
                    }
                }
                else if (num % 2 == 0 && num >= 2 && num <= 25)
                {
                    Console.WriteLine(num + " " + "is even and between 2 and 25");
                    Console.WriteLine("Do  you want to continute Y or N");
                    choice = Console.ReadLine().ToUpper();

                    if (choice == "Y")
                    {
                        keep = true;
                    }
                    else if (choice == "N")
                    {
                        keep = false;
                    }
                }
                else if (num % 2 == 0 && num >= 26 && num <= 60)
                {
                    Console.WriteLine(num + " " + "is even and between 26 and 60");
                    Console.WriteLine("Do  you want to continute Y or N");
                    choice = Console.ReadLine().ToUpper();

                    if (choice == "Y")
                    {
                        keep = true;
                    }
                    else if (choice == "N")
                    {
                        keep = false;
                    }
                }
                if (num > 60 && num % 2 == 0)
                {
                    Console.WriteLine(num + " " + "is even and greater than 60");
                    Console.WriteLine("Do  you want to continute Y or N");
                    choice = Console.ReadLine().ToUpper();

                    if (choice == "Y")
                    {
                        keep = true;
                    }
                    else if (choice == "N")
                    {
                        keep = false;
                    }
                }
                if (num > 60 && num % 2 != 0)
                {
                    Console.WriteLine(num + " " + "is odd and greater than 60");
                    Console.WriteLine("Do  you want to continute Y or N");
                    choice = Console.ReadLine().ToUpper();

                    if (choice == "Y")
                    {
                        keep = true;
                    }
                    else if (choice == "N")
                    {
                        keep = false;
                    }

                }
            }

        }
    }
}
