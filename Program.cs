using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppC2
{
    internal class Program
    {
        static int Sum(int a, int b)
        {
            return a + b;
        }
        static double Sum(double a, double b)
        {
            return a + b;
        }
        static int Multiply(int a, int b)
        {
            return a * b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите операцию: ");
            Console.WriteLine("0 - Выход.");
            Console.WriteLine("1 - Сложение: ");
            Console.WriteLine("2 - Произведение: ");
            
            string choice = Console.ReadLine();

            Console.WriteLine("Введите первое число: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            switch (choice)
            {
                case "1":
                    double sumResult = Sum(num1, num2);
                    Console.WriteLine("Результат сложение: " + sumResult);
                    break;

                case "2":
                    int multResult = Multiply((int)num1, (int)num2);
                    Console.WriteLine("Результат произведение: " + multResult);
                    break;

                case "0":
                    Console.WriteLine("Выход.");
                    break;

                default:
                    Console.WriteLine("Ошибка, попробуй ещё раз :3");
                    break;
            }
            
            }
        }
    }