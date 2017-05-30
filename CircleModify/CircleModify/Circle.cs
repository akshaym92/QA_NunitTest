    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleModify
{
    public class Circle
    {
        public const double pie= 3.14;
        public double radiusOfCircle { get; set; }
        //default construtor
        public Circle()
        {
        }
        public Circle(double radius)
        {
            this.radiusOfCircle = radius;

        }
        public  void AddToRadius(double num)
        {
            this.radiusOfCircle = this.radiusOfCircle + num;
            Console.WriteLine("New radius is {0}", radiusOfCircle);
            Console.Readline();
        }
        public void SubtractFromRadius(double num)
        {
            this.radiusOfCircle = this.radiusOfCircle - num;
            Console.WriteLine("New radius is {0}", radiusOfCircle);
            Console.ReadKey();

        }
        public void GetCircumference()

        {
            double circumference = 2 * pie * radiusOfCircle;
            Console.WriteLine("Circumference with given radius: {0}", circumference);
            Console.ReadKey();

        }
        public void GetArea()
        {
            double area = pie * radiusOfCircle * radiusOfCircle;
            Console.WriteLine("Area with given radius: {0}", area);
            Console.ReadKey();

        }
    }
}



