﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnitDemonstration;
using NUnit.Framework;
using NUnit.Framework.Legacy;


namespace TestClass
{
    //Pawanjot Mutation Testing
    public class Class1
    {
        [TestFixture]
        public class TriangleTest1
        {
            [Test]
            public void ValidTriangle_Input60and60and60_OutputValidTriangle()
            {
                //Arrange
                int firstAngle = 60;
                int secondAngle = 60;
                int thirdAngle = 60;

                string expected = "The triangle is valid.";

                //Act
                string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

                //Assert
               ClassicAssert.AreEqual(expected, actual);

            }
        }
    }
}
