using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CircleModify
{
    [TestFixture]
    public class CircleTest
    {
        [Test]
        public void AddToRadiusTest()
        {
            Circle circletestobj1 = new Circle();
            circletestobj1.radiusOfCircle = 10;
            circletestobj1.AddToRadius(6);
            Assert.AreEqual(16, circletestobj1.radiusOfCircle);
        }
    }
}
