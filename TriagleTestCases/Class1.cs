using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqaTriangle;
using NUnit.Framework;

namespace TriagleTestCases
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void TestCase_Equilateral()//Test case for equilateral
        {
            int side1 = 5, side2 = 5, side3 = 5;
            String st = "equilateral";
            String d = TriangleSolver.Analyze(side1, side2, side3);
            StringAssert.Contains(st, d);
        }
        [Test]
        public void TestCase_Isoceles()//Test case for isocelles
        {
            int side1 = 5, side2 = 7, side3 = 5;
            String st = "isoceles";
            String d = TriangleSolver.Analyze(side1, side2, side3);
            StringAssert.Contains(st, d);
        }
        [Test]
        public void TestCase_Scalene()//Test case for scalene
        {
            int side1 = 5, side2 = 7, side3 = 9;
            String st = "scalene";
            String d = TriangleSolver.Analyze(side1, side2, side3);
            StringAssert.Contains(st, d);
        }
        [Test]
        public void TestCase_Error()//Test case for wrong input
        {
            int side1 = 0, side2 = 0, side3 = 0;
            String st = "invalid";
            String d = TriangleSolver.Analyze(side1, side2, side3);
            StringAssert.Contains(st, d);
        }
        [Test]
        public void TestCase_Negative()//Test case for negative input
        {
            int side1 = -5, side2 = 7, side3 = 9;
            String st = "Incorrect";
            String d = TriangleSolver.Analyze(side1, side2, side3);
            StringAssert.Contains(st, d);
        }
        [Test]
        public void TestCase_NegativeScalene()//Test case for negative scalene
        {
            int side1 = -5, side2 = -7, side3 = -9;
            String st = "Incorrect";
            String d = TriangleSolver.Analyze(side1, side2, side3);
            StringAssert.Contains(st, d);
        }
        [Test]
        public void TestCase_NegativeIsoceles()//Test case for negative isoceles
        {
            int side1 = -5, side2 = 7, side3 = -5;
            String st = "Incorrect";
            String d = TriangleSolver.Analyze(side1, side2, side3);
            StringAssert.Contains(st, d);
        }
        [Test]
        public void TestCase_NegativeEquilateral()//Test case for negative equilateral
        {
            int side1 = -5, side2 = -5, side3 = 5;
            String st = "Incorrect";
            String d = TriangleSolver.Analyze(side1, side2, side3);
            StringAssert.Contains(st, d);
        }
    }
}
