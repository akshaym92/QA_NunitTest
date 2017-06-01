using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CircleModify;
namespace CircleModify_Test
{
    [TestFixture]
    public class CircleTest
    {
        [Test]
        public void Constructortest()
        {

            Circle constructtestobj = new Circle(2);

            Assert.AreEqual(2, constructtestobj.radiusOfCircle);

        }
        [Test]
        public void AddToRadius_withPositiveradius()

        {
            Circle Positiveradius = new Circle();
            Positiveradius.radiusOfCircle = 10;
            Positiveradius.AddToRadius(6);
            Assert.AreEqual(16, Positiveradius.radiusOfCircle);
        }
        [Test]
        public void AddToRadius_withnegetiveradiusTest()
        {
            Circle negativeradius = new Circle();
            negativeradius.radiusOfCircle = 2;
            negativeradius.AddToRadius(-4);
            Assert.AreEqual(-2, negativeradius.radiusOfCircle);

        }
        [Test]
        public void SubtractFromRadius_withPositiveradius()
        {

            Circle Positiverad = new Circle();
            Positiverad.radiusOfCircle = 10;
            Positiverad.SubtractFromRadius(6);
            Assert.AreEqual(4, Positiverad.radiusOfCircle);


        }
        [Test]
        public void SubtractFromRadius_withnegetiveradius()
        {
            Circle negativerad = new Circle();
            negativerad.radiusOfCircle = 2;
            negativerad.SubtractFromRadius(6);
            Assert.AreEqual(-4, negativerad.radiusOfCircle);
        }
        [Test]

        public void GetCircumference_postiveradius()
        {
            Circle circletestobj1 = new Circle();
            circletestobj1.radiusOfCircle = 3;
            circletestobj1.GetCircumference();
            Assert.AreEqual(18.84, circletestobj1.GetCircumference());
        }
        [Test]
        public void GetCircumference_negetiveradius()
        {
            Circle circletestobj2 = new Circle();
            circletestobj2.radiusOfCircle = -2;
            circletestobj2.GetCircumference();
            Assert.AreEqual(0, circletestobj2.GetCircumference());
        }

        [Test]
        public void GetAreaTest_positiveradius()
        {
            Circle circletestobj3 = new Circle();
            circletestobj3.radiusOfCircle = 2;
            circletestobj3.GetArea();
            Assert.AreEqual(12.56, circletestobj3.GetArea());
        }
        [Test]
        public void GetAreaTest_negetiveradius()
        {
            Circle circletestobj4 = new Circle();
            circletestobj4.radiusOfCircle = -2;
            circletestobj4.GetArea();
            Assert.AreEqual(0, circletestobj4.GetArea());


        }



    }
}