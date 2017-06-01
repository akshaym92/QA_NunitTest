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
            double radius = 0;
          
            

            Console.WriteLine("Enter the radius");
            radius = Convert.ToDouble(Console.ReadLine());

           

            Circle circleObj1 = new Circle(radius);
            do
            {
                Console.WriteLine("Select From the menu");
                Console.WriteLine("1.Add radius");
                Console.WriteLine("2.subtract radius");
                Console.WriteLine("3.Find Circumference");
                Console.WriteLine("4.Find Area");
                Console.WriteLine("5.Exit");



                try
                {
                    Console.Write("Please Enter your choice(1/2/3/4/5) : ");
                    choice = Convert.ToInt16(Console.ReadLine());

                }
                catch (Exception e)
                {
                    Console.WriteLine("Your choice is invalid...please enter a valid chocie(1/2/3/4/5)");
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
                        double numberToADD=0;
                        try
                        {
                            Console.WriteLine("Enter the value to Add");
                             numberToADD = Convert.ToInt32(Console.ReadLine());
                             circleObj1.AddToRadius(numberToADD);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Your input is invalid..A number is expected");
                            Console.WriteLine("Press any key to continue");
                            Console.ReadLine();
                        }
                       
                        break;

                    case 2:
                        try
                        {
                            int set = 0;
                            double numberToSubtract = 0;
                            do
                            {
                                Console.WriteLine("Enter the value to Subtract");
                                numberToSubtract = Convert.ToInt32(Console.ReadLine());
                                if (numberToSubtract > radius)
                                {
                                    Console.WriteLine("Enter a value less than the given radius");

                                }
                                else
                                {
                                    set = 1;
                                }

                            } while (set != 1);

                            circleObj1.SubtractFromRadius(numberToSubtract);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Your input is invalid..A number is expected");
                            Console.WriteLine("Press any key to continue");
                            Console.ReadLine();
                        }


                        break;
                    case 3:
                       
                       
                            double circumference = circleObj1.GetCircumference();
                            Console.WriteLine("Circumference of the cirle is:" + circumference);
                        
                       
                        break;
                    case 4:
                        double area = circleObj1.GetArea();
                        Console.WriteLine("area of the cirle is:" + area);

                        break;

                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            } while (choice != 5);
            } 

        }

    }











