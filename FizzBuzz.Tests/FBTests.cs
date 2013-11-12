using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz;

namespace FizzBuzz.Tests
{
    [TestFixture]
    class FBTests
    {


        [Test]
        public void MulitpleNumber3Test()
        {
            NUnit.Framework.StringAssert.AreEqualIgnoringCase("fizz", FizzBuzz.WorkOut(6));
        }
        [Test]
        public void Number3Test()
        {
            NUnit.Framework.StringAssert.AreEqualIgnoringCase("lucky", FizzBuzz.WorkOut(13));
        }
        [Test]
        public void Number5Test()
        {

            NUnit.Framework.StringAssert.AreEqualIgnoringCase("buzz", FizzBuzz.WorkOut(5));
        }

        [Test]
        public void Number15Test()
        {

            NUnit.Framework.StringAssert.AreEqualIgnoringCase("fizzbuzz", FizzBuzz.WorkOut(15));
        }

        [Test]
        public void DifferentNumberTest()
        {
            NUnit.Framework.StringAssert.AreEqualIgnoringCase("1", FizzBuzz.WorkOut(1));
            
        }

        [Test]
        public void ReportIntegerTest()
        {
           FizzBuzz.Display();
            NUnit.Framework.Assert.AreEqual(10, FizzBuzz.IntCount);

        }

    }

    
}
