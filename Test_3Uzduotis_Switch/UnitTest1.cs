using _3Uzduotis_UnitTesting_Switch;

namespace Test_3Uzduotis_Switch
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodSquare()
        {

            float userSquareNumber = 2;
            float expected = 4;

            float actual = Program.CalculateTheAreaOfTheSquare(userSquareNumber);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void TestMethodTriangle()
        { 
            float userTriangleNumber = 5;
            float userTriangleNumber2 = 2;

            float expected = 5;

            float actual = Program.CalculateTheAreaOfTheTriangle(userTriangleNumber, userTriangleNumber2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodCircle() 
        {
            float userCircleNumber = 10;
            float expected = 314;

            float actual = Program.CalculateTheAreaOfTheCircle(userCircleNumber);   

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodRectangle()
        {
            float userRectangleNumber = 3;
            float userRectangleNumber2 = 5;

            float expected = 15;

            float actual = Program.CalculateTheAreaOfTheRectangle(userRectangleNumber, userRectangleNumber2);

            Assert.AreEqual(expected, actual);
        }

    }
}