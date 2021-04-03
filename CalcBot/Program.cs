using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcBot
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double total;
            char zn;

            do
            {
                Console.Write("Введите первое число: ");

            } while (!double.TryParse(Console.ReadLine(), out a));

            do
            {
                Console.Write("\nВведите знак операции: ");
            } while (!char.TryParse(Console.ReadLine(), out zn));

            do
            {
                Console.Write("\nВведите второе число: ");
            } while (!double.TryParse(Console.ReadLine(), out b));


            if (zn == '+')
                {
                    total = a + b;
                    Console.WriteLine("\nРешение: " + a + " + " + b + " = " + total + "");
                }

                else if (zn == '-')
                {
                    total = a - b;
                    Console.WriteLine("\nРешение: " + a + " - " + b + " = " + total + "");
                }

                else if (zn == '*')
                {
                    total = a * b;
                    Console.WriteLine("\nРешение: " + a + " * " + b + " = " + total + "");
                }

                else if (zn == '/')
                {
                    total = a / b;
                    Console.WriteLine("\nРешение: " + a + " / " + b + " = " + total + "");
                    while (b == 0)
                    {
                        Console.WriteLine("На ноль делить нельзя!");
                        break;
                    }
                }


                else
                {
                    Console.WriteLine("Неизвестный оператор.");
                }

                Console.ReadKey();

            }
        }
    }


