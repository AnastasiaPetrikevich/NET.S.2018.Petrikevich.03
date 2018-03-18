using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FindNthRoot.Logic;

namespace FindNthRoot.Tests
{
    [TestFixture]
    public class RootTests
    {
        [TestCase(1, 5, 0.0001, ExpectedResult = 1)]
        [TestCase(8, 3, 0.0001, ExpectedResult = 2)]
        [TestCase(0.001, 3, 0.0001, ExpectedResult = 0.1)]
        [TestCase(0.04100625, 4, 0.0001, ExpectedResult = 0.45)]
        [TestCase(8, 3, 0.0001, ExpectedResult = 2)]
        [TestCase(0.0279936, 7, 0.0001, ExpectedResult = 0.6)]
        [TestCase(0.0081, 4, 0.1, ExpectedResult = 0.3)]
        [TestCase(-0.008, 3, 0.1, ExpectedResult = -0.2)]
        [TestCase(0.004241979, 9, 0.00000001, ExpectedResult = 0.545)]
        public static double FindNthRoot_Result(double number, int degree, double prescision) =>
            Root.FindNthRoot(number, degree, prescision);

        [Test]
        public void FindNthRoot_Number_8_Degree_Minus3_Throw_ArgumentOutOfRangeException()
            => Assert.Throws<ArgumentOutOfRangeException>(() => Root.FindNthRoot(8, -3, 0.001));
        [Test]
        public void FindNthRoot_Precision_4_Throw_ArgumentOutOfRangeException()
            => Assert.Throws<ArgumentOutOfRangeException>(() => Root.FindNthRoot(8, 3, 4));
        [Test]
        public void FindNthRoot_Precision_Minus1_Throw_ArgumentOutOfRangeException()
            => Assert.Throws<ArgumentOutOfRangeException>(() => Root.FindNthRoot(8, 3, -1));
    }
}
