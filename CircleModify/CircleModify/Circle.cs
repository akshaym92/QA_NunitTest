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
       
        public Circle()
        {
        }
        public Circle(double radius)
        {
            this.radiusOfCircle = radius;
            Console.WriteLine("Radius=" +this.radiusOfCircle);
           

        }
        public  void AddToRadius(double num)
        {
            this.radiusOfCircle = this.radiusOfCircle + num;
            Console.WriteLine(" Radius is {0}", radiusOfCircle);
            Console.WriteLine("Press a key to continue");
            Console.ReadLine();
        }
        public void SubtractFromRadius(double num)
        {
            this.radiusOfCircle = this.radiusOfCircle - (num);
            Console.WriteLine("Radius is {0}", radiusOfCircle);
            Console.WriteLine("Press a key to continue..");
            Console.ReadLine();

        }
        public double GetCircumference()

        {
            double circumference=0;
            if (this.radiusOfCircle > 0)
            {
                circumference = 2 * pie * radiusOfCircle;
                return circumference;
            }
            else
                {
                return circumference;

            }
          

        }
        public double GetArea()
        {
            double area=0;
            if (this.radiusOfCircle > 0)
            {
                area = pie * radiusOfCircle * radiusOfCircle;
                return area;
            }
            else
            {
                return area;
            }
           

        }
    }
}



