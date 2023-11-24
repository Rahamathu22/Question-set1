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
            Q22();
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
            int KiloMeter = GetInteger("Enter the kilometer to find the mile value :");
            double result = KiloToMiles(KiloMeter);
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

        public static void Q11()
        {
            int FirstValue = GetInteger("Enter the value of the first variable :");
            int SecondValue = GetInteger("Enter the value of the second variable :");
            SwapTwoValues(FirstValue, SecondValue);
        }

        public static void SwapTwoValues(int a, int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("The values after swap");
            Console.WriteLine("The value of the first variable:"+a);
            Console.WriteLine("The value of the second variable:"+b);

        }

        public static void Q12()
        {
            int FirstValue = GetInteger("Enter the value of the first variable :");
            int SecondValue = GetInteger("Enter the value of the second variable :");
            SwapWithoutTempVar(FirstValue, SecondValue);
        }

        public static void SwapWithoutTempVar(int a, int b)
        {
            a = a * b;
            b = a / b;
            a = a / b;
            Console.WriteLine("The values after swap");
            Console.WriteLine("The value of the first variable:" + a);
            Console.WriteLine("The value of the second variable:" + b);
        }

        public static void Q13()
        {
            int FirstValue = GetInteger("Enter the value of the first variable :");
            int SecondValue = GetInteger("Enter the value of the second variable :");
            SwapWithoutCausingOverflow(FirstValue, SecondValue);
        }

        public static void SwapWithoutCausingOverflow(int a, int b)
        {
            a = a ^ b;
            b = a ^ b;
            a = a ^ b;
            Console.WriteLine("The values after swap");
            Console.WriteLine("The value of the first variable:" + a);
            Console.WriteLine("The value of the second variable:" + b);
        }

        public static void Q14()
        {
            int Starting = GetInteger("Enter the starting range for generating the random values :");
            int End = GetInteger("Enter the ending range for generating the random values :");
            int result = RandomValues(Starting, End);
            Console.WriteLine("The random value is : "+result);
        }

        public static int RandomValues(int a, int b)
        {
            Random r = new Random();
            int random = r.Next(a, b);
            return random;
        }

        public static void Q15()
        {
            double Length = GetDouble("Enter the length in field");
            double Width = GetDouble("Enter the width in field");
            
            double result = AreaOfFieldInAcers(Length,Width);
            Console.WriteLine(result);
        }

        public static double AreaOfFieldInAcers(double length,double width)
        {
            int OneAcer = 43560;
            
            return (length*width/OneAcer);
        }

        public static void Q16()
        {
            int Number = GetInteger("Enter the Number");
            double result = SumNaturalNumbers(Number);
            Console.WriteLine(result);
        }

        public static double SumNaturalNumbers(int num)
        {
            return (num * (num + 1) / 2);
        }

        public static void Q17()
        {
            int Mark1 = GetInteger("Enter the mark in first subject :");
            int Mark2 = GetInteger("Enter the mark in second subject :");
            int Mark3 = GetInteger("Enter the mark in third subject :");
            Console.WriteLine(Average(Mark1, Mark2, Mark3));
        }

        public static double Average(int a, int b, int c)
        {
           double total = a + b + c;
            return (total / 3);
        }

        public static void Q18()
        {
            double Bill = GetDouble("Enter the bill amount: ");
            Console.WriteLine("Your bill amount with tax:"+CalculateTip(Bill));
        }

        public static double CalculateTip(double bill)
        {
            return (bill+(bill * (5 / 100.0)));
        }


        public static void Q19()
        {
            double Bill = GetDouble("Enter the bill amount: ");
            int tax = GetInteger("Enter the tax percentage:");
            Console.WriteLine("The net amount is :"+CalculateNetAmount(Bill,tax));
        }

        public static double CalculateNetAmount(double Amount,int taxpercent)
        {
            double netamount = (Amount / (1 + (taxpercent / 100.0)));
            return netamount;
        }


        public static void Q20()
        {
            double BasicPay = GetDouble("Enter the percent of basic pay: ");
            double DA = GetDouble("Enter the percent of DA: ");
            double TA = GetDouble("Enter the percent of TA: ");
            Console.WriteLine("The Grosspay is :"+GrossPay(BasicPay,DA,TA));
        }

        public static double GrossPay(double basicpay, double DA, double TA)
        {
            
            double da=basicpay*(DA/100.0);
            double ta=basicpay*(TA/100.0);
            double pf =basicpay*( 8 / 100.0);
            double grosspay = basicpay + da + ta - pf;
            return grosspay;
        }

        public static void Q21()
        {
            int Princple = GetInteger("Enter the principle amount:");
            int NumberOfTime = GetInteger("Enter the Number of time period:");
            double Rate = GetDouble("Enter the rate: ");
            Console.WriteLine("The calculated simple interest is :"+SimpleInterest(Princple,NumberOfTime,Rate));
        }

        public static double SimpleInterest(int p, int n, double r)
        {
            double si = (p * n * (r / 100.0));
            return si;
        }

        public static void Q22()
        {
            int Princple = GetInteger("Enter the principle amount:");
            int NumberOfTime = GetInteger("Enter the Number of time period:");
            int TimeDuration = GetInteger("Enter the time duration:");
            int Rate = GetInteger("Enter the rate:");
            Console.WriteLine("The compound interest is:"+CompoundInterest(Princple,NumberOfTime,TimeDuration,Rate));
        }

        public static double CompoundInterest(int p, int n,int t, int r)
        {
            double Compoundinterest = (p * ((1 + r / n) ^ (n * t)));
            return Compoundinterest;
        }

        public static void Q25()
        {
            Student();
        }

        public static void Student()
        {
            int RollNo = GetInteger("Enter your roll number:");
            Console.WriteLine("Enter your name:");
            string Name = Console.ReadLine();
            int Mark1 = GetInteger("Enter your mark in subject1:");
            int Mark2 = GetInteger("Enter your mark in subject2:");
            int Mark3 = GetInteger("Enter your mark in subject3:");
            int total = Mark1 + Mark2 + Mark3;
            Console.WriteLine("Mark in sub1 is:{0} ,sub2 is:{1} and sub3 is:{2}",Mark1,Mark2,Mark3);
            Console.WriteLine("Total:"+total);
            Console.WriteLine("Avrg is:"+Average(Mark1, Mark2, Mark3));
        }


    }
}
