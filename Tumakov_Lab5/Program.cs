using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov_Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 5.1 (Написать метод, возвращающий наибольшее из двух чисел)");
            try
            {
                Console.WriteLine("Введите 1 целое число (после ввода нажмите enter): ");
                bool a = int.TryParse(Console.ReadLine(), out int num1);
                Console.WriteLine("Введите 2 целое число (после ввода нажмите enter): ");
                bool b = int.TryParse(Console.ReadLine(), out int num2);
                Console.WriteLine($"Максимальное значение равно: {MaxValue(num1, num2)}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Упражнение 5.2 (Написать метод, который меняет местами значения двух передаваемых параметров)");
            Console.WriteLine("Введите 1 параметр (после ввода нажмите enter): ");
            string number1 = Console.ReadLine();
            Console.WriteLine("Введите 2 параметр (после ввода нажмите enter): ");
            string number2 = Console.ReadLine();
            Swap(ref number1, ref number2);
            Console.WriteLine($"Результат: {number1}, {number2}");

            Console.WriteLine("Упражнение 5.3 (Написать метод вычисления факториала числа)");
            try
            {
                Console.WriteLine("Введите число, факториал которого нужно вычислить(после ввода нажмите enter):");
                bool d = int.TryParse(Console.ReadLine(), out int num);
                long fact = 0;
                if (ComputeFactorial(num, out fact))
                {
                    Console.WriteLine($"Факториал от {num} это {fact}");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Вычислить факториал данного числа не удалось в связи с переполнением");
            }

            Console.WriteLine("Упражнение 5.4 (Написать рекурсивный метод вычисления факториала числа)");
            Console.WriteLine("Введите число, факториал которого нужно вычислить(после ввода нажмите enter):");
            bool c = int.TryParse(Console.ReadLine(), out int value);
            Console.WriteLine("Факториал = " + Factorial(value));

            Console.WriteLine("Домашнее задание 5.1 (Написать метод, который вычисляет НОД двух натуральных чисел)");
            try
            {
                Console.WriteLine("Введите 1 натуральное число (после ввода нажмите enter): ");
                int m = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите 2 натуральное число (после ввода нажмите enter): ");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine(Evklid(m, n));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
          
            Console.WriteLine("Домашнее задание 5.2 (Написать рекурсивный метод, вычисляющий значение n-го числа ряда Фибоначчи)");
            Console.WriteLine("Введите число N(после ввода нажмите enter): ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine($"Результат равен: {Fibonachi(N)}");
        }
        public static int MaxValue(int num1, int num2)
        {
            return Math.Max(num1, num2);
        }
        static void Swap(ref string number1, ref string number2)
        {
            string temp = number1;
            number1 = number2;
            number2 = temp;
        }
        public static bool ComputeFactorial(int num, out long fact)
        {
            checked
            {
                fact = 1;
                for (int i = 2; i <= num; i++)
                {
                    fact *= i;
                }
                return true;
            }
        }
        static int Factorial(int value)
        {
            if (value == 0)
            {
                return 1;
            }
            return value * Factorial(value - 1);
        }
        static int Evklid(int m, int n)
        {
            while (m != n)
            {
                if (m > n)
                {
                    m = m - n;
                }
                else
                {
                    n = n - m;
                }
            }

            return n;
        }
        static int Fibonachi(int N)
        {
            if (N == 0)
            {
                return 0;
            }
            else if (N == 1 || N == 2)
            {
                return 1;
            }
            else
            {
                return Fibonachi(N - 1) + Fibonachi(N - 2);
            }
        }

    }
}
