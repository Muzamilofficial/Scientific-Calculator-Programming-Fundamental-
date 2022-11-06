using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scientific_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {            //The First Page Which Holds The INformatio Of This App

            Console.Title = "MK Scientific Operation Calculator)";
            Console.BufferHeight = 100;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\n\n\n");
            Console.WriteLine("\t\t\tWelcome To Scientic Calculator Where You Perform Scientific Operations Easily");
            Console.WriteLine("\n\n");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t\t(A Scientific Calculator Project By Muzamil Khan Muneeb Kazmi And Zain Zahid)");
            Console.WriteLine("\n\n");
            Console.WriteLine("\t\t\t\t\t\tPlease Give Rating To Our App");
            Console.WriteLine("\n\n");
            Console.WriteLine("\t\t\t\t\t\tPRESS Space Bar To Continue.......");
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n");
            Console.WriteLine("\t\t\t\t\tFunctions Of This Calculator");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Gray;

            // Introduction To Operations Which This Calculator Performs

            Console.WriteLine("\n");
            Console.WriteLine("\t\t\t\tThis Calculator Performs Following Major Functions");
            Console.WriteLine("\tYou Should Input The Values Again If You  HAve To Do Basic Functions Like Calculating Area OF Circle and etc");
            Console.WriteLine("\n");
            Console.WriteLine("\t1): Addition");
            Console.WriteLine("\t2): Subtraction");
            Console.WriteLine("\t3): Multiplication");
            Console.WriteLine("\t4): Division");
            Console.WriteLine("\t5): Percentage");
            Console.WriteLine("\t6): Exponential Power");
            Console.WriteLine("\t7): Power");
            Console.WriteLine("\t8): Area Of Circle");
            Console.WriteLine("\t9): Area Of Rectangle");
            Console.WriteLine("\t10): Convert degrees in to radians");
            Console.WriteLine("\t11): Calculate The Value Of Pie");
            Console.WriteLine("\t12): Calculate The Cube");
            Console.WriteLine("\n\n");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\t\t\t\t\tPress Any Key To Start The CAlculator.......");
            Console.ReadKey();
            Console.ResetColor();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t\t\tWelcome To The Mk Scientific Calculator");
            Console.ResetColor();
            // Declaring Of Input

            int functions = 0;
            double sum = 0, num, c, l, b, d;

            // Take First Inputs From User
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\t\t\tEnter The First Number Here (For Simple Calculations): ");
            string stringNum1 = Console.ReadLine();
            double num1 = Convert.ToDouble(stringNum1);

            // Take First Inputs From User

            Console.Write("\t\t\tEnter The Second Number Here (For Simple Calculations) : ");
            string stringNum2 = Console.ReadLine();
            double num2 = Convert.ToDouble(stringNum2);
            Console.WriteLine("\n\n");
            Console.ResetColor();
            //The Function Which I Used In This Calculator

            Console.WriteLine("Select The Functions You Want To Do: ");
            Console.WriteLine("\n");
            Console.WriteLine("(+) Addition");
            Console.WriteLine("(-) Subtraction");
            Console.WriteLine("(*) Multiplication");
            Console.WriteLine("(/) Division");
            Console.WriteLine("(%) Percentage");
            Console.WriteLine("(Ep) Exponential Power");
            Console.WriteLine("(p) Power");
            Console.WriteLine("(a) Area Of Circle");
            Console.WriteLine("(r) Area Of Rectangle");
            Console.WriteLine("(d) Convert degrees in to radians");
            Console.WriteLine("(pie) Calculate The Value Of Pie");
            Console.WriteLine("(cube) Calculate The Cube");
            Console.WriteLine("\n");
            string operators = Console.ReadLine();

            //This Portion Is For Declaring The Function Which I have Used In This Project

            if (operators == "+" || operators == "Addition")
            {
                functions = 1;
            }
            else if (operators == "-" || operators == "Subtraction")
            {
                functions = 2;
            }
            else if (operators == "*" || operators == "Multiplication")
            {
                functions = 3;
            }
            else if (operators == "/" || operators == "Division")
            {
                functions = 4;
            }
            else if (operators == "%" || operators == "Percentage")
            {
                functions = 5;
            }
            else if (operators == "Ep" || operators == "Exponential Power")
            {
                functions = 6;
            }
            else if (operators == "p" || operators == "Power")
            {
                functions = 7;
            }
            else if (operators == "a" || operators == "Area Of Circle")
            {
                functions = 8;
            }
            else if (operators == "r" || operators == "Area Of Rectangle")
            {
                functions = 9;
            }
            else if (operators == "d" || operators == "Convert degrees in to radians")
            {
                functions = 10;
            }
            else if (operators == "pie" || operators == "Calculate The Value Of Pie")
            {
                functions = 11;
            }
            else if (operators == "cube" || operators == "Calculate The Cube")
            {
                functions = 12;
            }
            else
            {
                Console.WriteLine("You Have Enter An Invalid Function And Your Sum Is 0");
            }
            // The Portion Of Swich Cases Used In This Project

            switch (functions)
            {
                case 1:
                    sum = num1 + num2;
                    break;

                case 2:
                    sum = num1 - num2;
                    break;

                case 3:
                    sum = num1 * num2;
                    break;

                case 4:
                    sum = num1 / num2;
                    break;

                case 5:
                    sum = num1 % num2;
                    break;
                case 6:
                    sum = Math.Pow(num1, num2);
                    break;

                case 7:
                    Console.Write("So Enter A New Number To Get The Power: ");
                    num = double.Parse(Console.ReadLine());
                    sum = num * num;
                    break;

                case 8:
                    Console.Write("So Enter Here The Circumference Of A Circle: ");
                    c = double.Parse(Console.ReadLine());
                    sum = c / 2 * 3.14;
                    break;

                case 9:
                    Console.Write("So Enter Here The Leghth Of A Circle: ");
                    l = double.Parse(Console.ReadLine());
                    Console.Write("So Enter Here The Breath Of A Circle: ");
                    b = double.Parse(Console.ReadLine());
                    sum = l * b;
                    break;


                case 10:
                    Console.Write("So Enter Here The New Number In Degrees here to convert it into radians: ");
                    d = double.Parse(Console.ReadLine());
                    sum = d * 3.14 / 180;
                    break;

                case 11:
                    Console.Write("So Enter Here The Diameter: ");
                    d = double.Parse(Console.ReadLine());
                    Console.Write("So Enter Here The Circumference: ");
                    c = double.Parse(Console.ReadLine());
                    sum = c / d;
                    break;

                case 12:
                    Console.Write("So Enter Here New Number: ");
                    num = double.Parse(Console.ReadLine());
                    sum = num * num * num;
                    break;
            }

            // The Result Shows Here\
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("\t\t\t\tThe Result Of Your Given Inputs Are: {0}", sum);
            Console.ReadLine();
        }
    }
}