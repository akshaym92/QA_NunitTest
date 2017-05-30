using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleModify
{
    public class Program
    {

        static void Main(string[] args)
        {
            int choice = 0;



            Circle circleObj1 = new Circle();
            Console.WriteLine("Enter the radius");
            circleObj1.radiusOfCircle = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Select From the menu");
            Console.WriteLine("1.Add radius");
            Console.WriteLine("2.subtract radius");
            Console.WriteLine("3.Find Circumference");
            Console.WriteLine("4.Find Area");
            Console.WriteLine("5.Exit");



            try
            {
                Console.Write("Please Enter your choice(1/2/3/4) : ");
                choice = Convert.ToInt16(Console.ReadLine());

            }
            catch (Exception e)
            {
                Console.WriteLine("Your choice is invalid...please enter a valid chocie(1/2/3)");
                Console.WriteLine("Press any key to continue");
                Console.ReadLine();

            }
            finally
            {
                Console.Clear();
            }

            switch (choice)
            {
                case 1:

                    Console.WriteLine("Enter the value to Add");
                    double numberToADD = Convert.ToInt32(Console.ReadLine());
                    circleObj1.AddToRadius(numberToADD);
                    break;
                case 2:
                    Console.WriteLine("Enter the value to Subtract");
                    double numberToSubtract = Convert.ToInt32(Console.ReadLine());
                    circleObj1.SubtractFromRadius(numberToSubtract);
                    break;
                case 3:
                    circleObj1.GetCircumference();
                    Console.ReadKey();
                    break;
                case 4:
                    circleObj1.GetArea();
                    Console.ReadKey();
                    break;

                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }

        }

    }
}










