using System;
namespace _3Uzduotis_UnitTesting_Switch
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Apskaiciuoti plota");

            Console.WriteLine("Pasirinkite viena figura: " +
            "\n-Kvadratas - 1 \n-Trikampis - 2  \n-Apskritimas - 3 \n-Staciakampis - 4");
            float figure = Convert.ToSingle(Console.ReadLine());

            switch (figure)
            {
                case 1:
                    Console.WriteLine("Jus pasirinkote kvadrata. " +
                    "Iveskite krastines ilgi:");
                    float userSquareNumber = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Kvadrato plotas: " + CalculateTheAreaOfTheSquare(userSquareNumber) + " cm");
                    break;
                case 2:
                    Console.WriteLine("Jus pasirinkote trikampi.Iveskite aukstines ir pagrindo ilgi: ");
                    float userTriangleNumber = Convert.ToSingle(Console.ReadLine());
                    float userTriangleNumber2 = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Trikampio plotas: " + CalculateTheAreaOfTheTriangle(userTriangleNumber, userTriangleNumber2) + " cm");
                    break;
                case 3:
                    Console.WriteLine("Jus pasirinkote apskritima. Iveskite spindulio ilgi: ");
                    float userCircleNumber = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Apskritimo plotas: " + CalculateTheAreaOfTheCircle(userCircleNumber) + " cm");
                    break;
                case 4:
                    Console.WriteLine("Jus pasirinkote staciakampi. Iveskite dvieju krastiniu ilgius:");
                    float userRectangleNumber = Convert.ToSingle(Console.ReadLine());
                    float userRectangleNumber2 = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Staciakampio plotas: " + CalculateTheAreaOfTheRectangle(userRectangleNumber, userRectangleNumber2) + " cm");
                    break;
            }
        }
    
        public static float CalculateTheAreaOfTheSquare(float userSquareNumber)
        {
            return userSquareNumber * userSquareNumber;
        }

        public static float CalculateTheAreaOfTheTriangle(float userTriangleNumber, float userTriangleNumber2)
        {
            return 0.5f * userTriangleNumber * userTriangleNumber2;
        }

        public static float CalculateTheAreaOfTheCircle(float userCircleNumber)
        {
            return 3.14f * userCircleNumber * userCircleNumber;
        }

        public static float CalculateTheAreaOfTheRectangle(float userRectangleNumber, float userRectangleNumber2)
        {
            return userRectangleNumber * userRectangleNumber2;
        }
    }

}