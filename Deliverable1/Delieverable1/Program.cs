using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delieverable1
{
    class Program
    {
      /*  Program()
        {
            int first_num, sec_num, ld, fd, md, ldd, fdd, mdd, temp, tempp, num = 0;
            string input1, input2 = "";
        }

        public static String checkFirstNum(String t)
        {
            int num, first_num = 0;
            string input1, input2 = "";

            if ( t.Length > 3 || Int32.TryParse(t, out num) == false ||t == " ")
            {

                do
                {
                    Console.WriteLine("Enter in a 3 digit number please {-\\-}");
                  t = Console.ReadLine();
                } while ( Int32.TryParse(t, out num) == false || t == " ");


                first_num = Convert.ToInt32(t);
                Console.WriteLine("Correct input finally, your first 3 digit number is" + " " + first_num + "/n");

            }
            else 
            {
                first_num = Convert.ToInt32(t);
                Console.WriteLine("Your first integer is" + " " + first_num);
                t = Convert.ToString(first_num);
            }
            return t;
        }
        


        public static String checkSecNum(String dummy)
        {
            int num, sec_num = 0;
            string input1, input2 = "";

            if ( dummy.Length > 3 || Int32.TryParse(dummy, out num) == false || dummy == " ")
            {

                do
                {
                    Console.WriteLine("Enter in a 3 digit number please {-\\-}");
                    dummy = Console.ReadLine();
                } while (Int32.TryParse(dummy, out num) == false || dummy == " ");


              sec_num = Convert.ToInt32(dummy);
                Console.WriteLine("Correct input finally, your first 3 digit number is" + " " + sec_num + "\n");

            }
            else
            {
                sec_num = Convert.ToInt32(dummy);
                Console.WriteLine("Your second integer is" + " " + sec_num);
                dummy = Convert.ToString(sec_num);
            }
            return dummy;
        }*/

        static void Main(string[] args)

        {
          //  Program program = new Program();
            int first, second, ld, fd, md, temp, temp2, temp3, sec_f_d,sec_m_d,sec_l_d,num2,num,last,sum1,sum2,sum3 = 0; //inttailize variables
            String input1,input2 = "";     //holds user input

            
            Console.WriteLine("Input your first 3 digit integer");
            input1 = Console.ReadLine();                //holds user first integer

            //Program.checkFirstNum(input1);

            num = Convert.ToInt32(input1);          //Convert user first input which is a string to a int

            Console.WriteLine(num + "\n");              //Display first integer

            fd = (num / 100);              //get int in hundreds place
            Console.WriteLine(fd);
            temp = (num / 10);           //gets digit in hundreds and tens place so I can seprate the two
            md = (temp % 10);          //get int in tens place
            Console.WriteLine(md);
            ld = (num % 100);             //get int in tens and ones place
            last = (ld % 10);           //get int in ones place
            last = (ld % 10);
            Console.WriteLine(last);

            Console.WriteLine("Input your second 3 digit integer");
            input2 = Console.ReadLine();

            num2 = Convert.ToInt32(input2);      //Convert user second input which is a string to a int
            sec_f_d = (num2 / 100);                  //get int in hundreds place
            Console.WriteLine(sec_f_d);
            temp2 = (num2 / 10);                        //gets digit in hundreds and tens place so I can seprate the two
            sec_m_d = (temp2 % 10);                                     //  //get int in tens place
            Console.WriteLine(sec_m_d);
            temp3 = (num2 % 100);                  //get int in tens and ones place
            sec_l_d = (temp3 % 10);                   //get int in ones place
            Console.WriteLine(sec_l_d);

            sum1 = fd + sec_f_d;                            //total first ints of both integers
            sum2 = md + sec_m_d;         //total second ints of both integers
            sum3 = ld + sec_l_d;             //total third ints of both integers

            if (sum1 != sum2 && sum1 != sum3 && sum2 != sum1 && sum2 != sum3 && sum3 != sum1 && sum3 != sum2)       // If all sums are not equal to each other print false
            {
                Console.WriteLine("False");
            }
            else if( sum1 == sum2 && sum1 == sum3 && sum2 == sum1 && sum2 ==sum3 && sum3 == sum1 && sum3 == sum2)   // If all sums are not equal to each other print true
            {
                Console.Write("True");
            }




            //   Console.WriteLine("Input your second 3 digit integer");
            //    input2 = Console.ReadLine();

            //  Program.checkSecNum(input2);


            /*   if (input1.Length > 3 || Int32.TryParse(input1, out num) == false || input1 == " "  )
               {

                   do
                   {
                       Console.WriteLine("Enter in a 3 digit number please {-\\-}");
                       input1 = Console.ReadLine();
                   } while (input1.Length > 3 || Int32.TryParse(input1, out num) == false || input1 == " " );


                    first_num = Convert.ToInt32(input1);
                   Console.WriteLine("Correct input finally, your first 3 digit number is" + " " + first_num);

               }
               else if (input1.Length == 3){
                first_num = Convert.ToInt32(input1);
                  Console.WriteLine("Your first integer is" + " " + first_num);
               }


               Console.WriteLine("Input your 2nd 3 integer");
               input2 = Console.ReadLine();

               if (input2.Length > 3 || Int32.TryParse(input2, out num) == false || input2 == " ")
               {

                   do
                   {
                       Console.WriteLine("Enter in a 3 digit number please for your 2nd number {-\\-}");
                       input2 = Console.ReadLine();
                   } while (input2.Length > 3 || Int32.TryParse(input2, out num) == false || input2 == " ");

                   sec_num = Convert.ToInt32(input2);
                   Console.WriteLine("Correct input finally, your first 3 digit number is  " + " " + input2);

               }
               else if (input2.Length == 3)
               {
                   sec_num = Convert.ToInt32(input2);
                   Console.WriteLine("Your second integer is" + " " + sec_num);
               }



               // int i = Convert.ToInt32(Console.ReadLine());

               /* if (i > 3)
                {

                }*/




            //Console.WriteLine("First integer seperated" + " " + first_num);
            /* if( Int32.TryParse(input2, out num)== true)
               {
                   first = Convert.ToInt32(input2);
               }
                  fd = (num/ 100);
                  Console.WriteLine(fd);
                  temp = (fd / 10);
                  md = (temp % 10);
                  Console.WriteLine(md);
                  ld = (md % 10);
                  Console.WriteLine(ld);

               second = Convert.ToInt32(input2);

                  Console.WriteLine(second);
                  fdd = ( second / 100);
                  Console.WriteLine(fdd);
                  tempp = (fdd / 10);
                  mdd = (tempp % 10);
                  Console.WriteLine(mdd);
                  ldd = (mdd % 10);
                  Console.WriteLine(ldd);



               /* while( i > 0)
                {
                    ld = i%10;

                }*/
            Console.ReadKey();
        }
    }
}
