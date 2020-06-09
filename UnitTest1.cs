using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Opg1StaticMethod;

namespace OPG2_UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        private string t = "10 20 30";





        [TestMethod]
        public void TestMethod1()
        {
            //Arrange 
            int test1 = TransportCalc.Total(t);
            //Act 

            //Assert
            Assert.AreEqual(60, test1);

            Assert.AreNotEqual(61, test1);


        }
        [TestMethod, ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void OutOfRange()
        {
            TransportCalc.Average(20002, 12);

        }
        [TestMethod]
        public void TestAverage()
        {
          double result =  TransportCalc.Average(1000, 100);

            Assert.AreEqual(1000, result);
        }



    }
}

//a.Det er tilstrækkeligt først at teste metoden Total.

//b.Udvid derefter din anden metode Average, så der kastes en passende Exception, hvis antal km falder uden for det tilladte interval: 0 - 2000 (se domænebeskrivelsen). 


//c.Udvid så din test til at vise, at der bliver kastet den forventede Exception, hvis antal km er udenfor det tilladte interval.


//d.Kør testen og overvej din tests ”Code Coverage”.
