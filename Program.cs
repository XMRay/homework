 using System;

namespace Calculator
    {
        class Calculator
        {
            public static double Res(double a, double b, string c)//a第一个数，b第二个数，c运算符号
            {
                double result = double.NaN; 
                switch (c)
                {
                    case "+":
                        result = a + b;
                        break;
                    case "-":
                        result = a - b;
                        break;
                    case "*":
                        result = a * b;
                        break;
                    case "/":                        
                        if (b != 0)
                        {
                            result = a / b;
                        }
                        break;                   
                    default:
                        break;
                }
                return result;
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                bool endApp = false;
                Console.WriteLine("计算器\r");
                Console.WriteLine("------------------------\n");

                while (!endApp)
                {
                    string numA = "";                      //第一个输入
                    string numB = "";                      //第二个输入
                    double result = 0;

                    // 第一个数的输入
                    Console.WriteLine("输入第一个数");
                    numA = Console.ReadLine();
                    double cleanA = 0;
                    while (!double.TryParse(numA, out cleanA))
                    {
                        Console.WriteLine("输入错误，请输入一个数字");
                        numA = Console.ReadLine();
                    }
                   
                    // 输入运算
                    Console.WriteLine("请选择运算（+、-、*、/)");
                    string c = Console.ReadLine();
                   
                    // 第二个数的输入
                    Console.WriteLine("输入第二个数");
                    numB = Console.ReadLine();
                    double cleanB = 0;
                    while (!double.TryParse(numB, out cleanB))
                    {
                        Console.WriteLine("输入错误，请输入一个数字");
                        numB = Console.ReadLine();
                    }

                    try
                    {
                        result = Calculator.Res(cleanA, cleanB, c);
                        if (double.IsNaN(result))
                        {
                            Console.WriteLine("输入值或运算符导致错误\n");
                        }
                        else Console.WriteLine("结果是: {0:0.##}\n", result);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("对不起发生错误\n - 错误内容: " + e.Message);
                    }

                    Console.WriteLine("------------------------\n");

                    // 循环操作
                    Console.Write("输入“n”关闭应用或其他键继续");
                   
                    if (Console.ReadLine() == "n") endApp = true;

                    Console.WriteLine("\n"); 
                }
                return;
            }
        }
    }

