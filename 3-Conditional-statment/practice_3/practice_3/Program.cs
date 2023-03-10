using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace practice_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //if & else
            /*
            int age;
            Console.WriteLine("Please enter your age : ");
            age = Convert.ToInt32(Console.ReadLine());

            if(age >= 13 && age <= 19)
            {
                Console.WriteLine("You are a Teenager");
            }
            else
            {
                Console.WriteLine("You are not a Teenager");
            }
            */
            /*
            float obtained_marks;
            int total_marks;
            float per;
            Console.WriteLine("Enter Your Obtained marks : ");
            obtained_marks = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter Total marks : ");
            total_marks = Convert.ToInt32(Console.ReadLine());
            per = (obtained_marks / total_marks) * 100;
            Console.WriteLine($"{per:F2}");

            if (per >= 80 && per <= 100)
            {
                Console.WriteLine("Your Grade is A+");
            }
            else if (per >= 70 && per < 80)
            {
                Console.WriteLine("Your Grade is A");
            }
            else if (per >= 60 && per < 70)
            {
                Console.WriteLine("Your Grade is B");
            }
            else if (per >= 50 && per < 60)
            {
                Console.WriteLine("Your Grade is C");
            }
            else if (per >= 40 && per < 50)
            {
                Console.WriteLine("Your Grade is D");
            }
            else
            {
                Console.WriteLine("You are Failed");
            }
            */

            /* nested if-else

            string p1, p2, p3;
            Console.WriteLine("Enter Password 1 : ");
            p1 = Console.ReadLine();
            if (p1 == "12345")
            {
                Console.WriteLine("Level 1 is Cleared");
                Console.WriteLine("Enter Password 2 : ");
                p2 = Console.ReadLine();
                if (p2 == "00000")
                {
                    Console.WriteLine("Level 2 is Cleared");
                    Console.WriteLine("Enter Password 3 : ");
                    p3 = Console.ReadLine();

                    if (p3 == "11111")
                        {
                        Console.WriteLine("Congratulation you Win....");
                        }
                          else
                              {
                               Console.WriteLine("Incorrect Password 3 you lost");
                              }
                }
                  else
                  {
                    Console.WriteLine("Incorrect Password 2");
                  }
            }
            else
            {
                Console.WriteLine("Incorrect Password 1");
            }
            */
            /*switch case

            int day;
            Console.WriteLine("Enter day Number : ");
            day = Convert.ToInt32(Console.ReadLine());
            switch (day)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("The day is Monday");
                    break;
                case 4:
                    Console.WriteLine("The day is tuesday");
                    break;
                case 5:
                    Console.WriteLine("The day is Wednesday");
                    break;
                case 6:
                    Console.WriteLine("The day is Thursday");
                    break;
                case 7:
                    Console.WriteLine("The day is Friday");
                    break;
                case 8:
                    Console.WriteLine("The day is Saturday");
                    break;
                case 9:
                    Console.WriteLine("The day is Sunday");
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
            */
            Console.WriteLine("Enter your Pizza flavour : ");
            string pizza = Console.ReadLine();
            switch (pizza) {
                case "fajita":
                    Console.WriteLine("You have selected Fajita Pizza...");
                    break;
                case "pepproni":
                    Console.WriteLine("You have selected Pepproni Pizza...");
                    break;

                case "tikka":
                    Console.WriteLine("Please select which Chicken Part/Piece you want...");
                    string tikka = Console.ReadLine();
                    switch (tikka)
                    {
                        case "chest":
                            Console.WriteLine("You have selected Chest Tikka Pizza...");
                            break;

                        case "leg":
                            Console.WriteLine("You have selected Leg Tikka Pizza...");
                            break;
                    }
                    break;
                case "meshroom":
                    Console.WriteLine("You have selected Meshroom Pizza...");
                    break;

                default:
                    Console.WriteLine("Pizza Flovour not available...");
                    break;
            }

            Console.ReadLine();
            

        }
    }
}
