using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionSet1
{
    class Program
    {
        static void Main(string[] args)
        {
            Q10();
        }


        public static int GetInteger(string message)
        {
            Console.WriteLine(message);
            int Number = int.Parse(Console.ReadLine());
            return Number;
        }

        public static double GetDouble(string information)
        {
            Console.WriteLine(information);
            double Number = double.Parse(Console.ReadLine());
            return Number;
        }


        public static void Q1()
        {
            int FirstValue = GetInteger("Enter the first value");
            int SecondValue = GetInteger("Enter the second value");
            int AddResult = Addition(FirstValue, SecondValue);
            int DiffResult = Difference(FirstValue, SecondValue);
            int ProdResult = Product(FirstValue, SecondValue);
            Console.WriteLine("The addition of two numbers:"+AddResult);
            Console.WriteLine("The difference of two numbers:"+DiffResult);
            Console.WriteLine("The product of two numbers:"+ProdResult);
        }

        public static int Addition(int a, int b)
        {
            return a + b;
        }

        public static int Difference(int a, int b)
        {
            return (Math.Abs(a - b));
        }

        public static int Product(int a, int b)
        {
            return a * b;
        }

       
        public static void Q2()
        {
            int FirstValue = GetInteger("Enter the first value");
            int SecondValue = GetInteger("Enter the second value");
            double result = PowerInteger(FirstValue, SecondValue);
            Console.WriteLine(result);
        }

        public static double PowerInteger(int a, int b)
        {
            return (Math.Pow(a, b));
        }

        public static void Q3()
        {
            double Length = GetDouble("Enter the value for length");
            double Width = GetDouble("Enter the value for width");
            double Heigth = GetDouble("Enter the value for height");
            double result = VolumeOfRectangle(Length, Width, Heigth);
            Console.WriteLine("The volume of rectangle is:"+result);
        }

        public static double VolumeOfRectangle(double l, double w, double h)
        {
            return l * w * h;
        }

        public static void Q4()
        {
            int Radius = GetInteger("Enter the value for radius");
            double result = PerimeterOfCircle(Radius);
            Console.WriteLine("Perimeter of the circle:"+result);
        }

        public static double PerimeterOfCircle(int r)
        {
           double pi = Math.PI;
           return (2 * pi * r);
        }

        public static void Q5()
        {
            int Numerator = GetInteger("Enter the numerator value");
            int Denominator = GetInteger("Enter the denominator value");
            int Quotresult = Quotient(Numerator, Denominator);
            int Remairesult = Remainder(Numerator, Denominator);
            Console.WriteLine("The Quotient and the remainder is: {0}:{1}",Quotresult,Remairesult);
        }

        public static int Quotient(int a, int b)
        {
            return a / b;
        }

        public static int Remainder(int a, int b)
        {
            return a % b;
        }

        public static void Q6()
        {
            int Value = GetInteger("Enter the value to find the square value :");
            int result = SquareValue(Value);
            Console.WriteLine("The square value of the given number is :"+result);
        }

        public static int SquareValue(int a)
        {
            return a * a;
        }

        public static void Q7()
        {
            int Value = GetInteger("Enter the value to find the square root value :");
            double result = SquareRootValue(Value);
            Console.WriteLine("The square root value of the given number is :" + result);
        }

        public static double SquareRootValue(int num)
        {
            return (Math.Sqrt(num));
        }

        public static void Q8()
        {
            double Breadth = GetDouble("Enter the value for breadth");
            double Heigth = GetDouble("Enter the value for height");
            double result = AreaOfTriangle(Breadth, Heigth);
            Console.WriteLine("The area of the triangle is:"+result);
        }

        public static double AreaOfTriangle(double b, double h)
        {
            return (1 / 2.0*(b * h));
        }

        public static void Q9()
        {
            int Value = GetInteger("Enter the kilometer to find the mile value :");
            double result = KiloToMiles(Value);
            Console.WriteLine("The mile calculation of the given number is :" + result);
        }

        public static double KiloToMiles(int num)
        {
            double OneMile = 1.60934;
            return (num * OneMile);
        }

        public static void Q10()
        {
            int Celsius = GetInteger("Enter the celsius :");
            double result = CelsiusToFahrenheit(Celsius);
            Console.WriteLine("The fahrenheit of the given celsius is :" + result);
        }

        public static double CelsiusToFahrenheit(int celsius)
        {
            return ((celsius * 9 / 5.0) + 32); ;
        }

    }
}
