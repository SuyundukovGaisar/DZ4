using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1(Вывести на экран массив из 20 случайных чисел и ввести два числа из массива,которые нужно поменять местами)");
            int[] numbers = new int[20];
            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 100);
            }
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Введите номер первого числа: ");
            int firstIndex = int.Parse(Console.ReadLine()) - 1;
            Console.Write("Введите номер второго числа: ");
            int secondIndex = int.Parse(Console.ReadLine()) - 1;
            if (firstIndex < 0 || firstIndex >= numbers.Length || secondIndex < 0 || secondIndex >= numbers.Length)
            {
                Console.WriteLine("Введенные индексы являются недопустимыми.");
                return;
            }
            int temp = numbers[firstIndex];
            numbers[firstIndex] = numbers[secondIndex];
            numbers[secondIndex] = temp;
            Console.WriteLine("Получившийся массив:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Задание 2(Написать метод, где в качества аргумента будет передан массив.Вывести сумму,(ref) произведение,(out) среднее арифметическое элементов массива)");
            Console.WriteLine("Сумма элементов: " + CalculateSum(1, 2, 3, 4, 5));
            Console.WriteLine("Произведение элементов: " + CalculateProduct(out int product, 1, 2, 3, 4, 5));
            Console.WriteLine("Среднее арифметическое: " + CalculateAverage(1, 2, 3, 4, 5));

            Console.WriteLine("Задание 3(Если числа от 0 до 9, то необходимо в консоли нарисовать изображение цифры в виде символа, если ввести exit или закрыть программа закроется)");
            bool exit = false;
            while (!exit)
            {
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("Введите число от 0 до 9 (для выхода введите 'exit'): ");
                string input = Console.ReadLine();

                if (input.ToLower() == "exit" || input.ToLower() == "закрыть")
                {
                    exit = true;
                    continue;
                }

                int number;
                if (!int.TryParse(input, out number))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ошибка! Введено не число!");
                    System.Threading.Thread.Sleep(3000);
                    continue;
                }

                if (number < 0 || number > 9)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ошибка! Введено число вне диапазона!");
                    System.Threading.Thread.Sleep(3000);
                    continue;
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Изображение цифры {0}:", number);
                DrawNumber(number);
                Console.WriteLine();

                Console.WriteLine("Нажмите любую клавишу для продолжения...");
                Console.ReadKey();
            }

        }
        static int CalculateSum(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
        static int CalculateProduct(out int product, params int[] numbers)
        {
            product = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                product *= numbers[i];
            }
            return product;
        }
        static double CalculateAverage(params int[] numbers)
        {
            int sum = CalculateSum(numbers);
            double average = (double)sum / numbers.Length;
            return average;
        }
        static void DrawNumber(int number)
        {
            string[] digits = new string[]
            {
            "  ###  \n #   # \n #   # \n #   # \n  ###  ", // 0
            "   #   \n   #   \n   #   \n   #   \n   #   ", // 1
            "  ###  \n     # \n  ###  \n #     \n  ###  ", // 2
            "  ###  \n     # \n  ###  \n     # \n  ###  ", // 3
            " #   # \n #   # \n  ###  \n     # \n     # ", // 4
            "  ###  \n #     \n  ###  \n     # \n  ###  ", // 5
            "  ###  \n #     \n  ###  \n #   # \n  ###  ", // 6
            "  ###  \n     # \n    #  \n   #   \n   #   ", // 7
            "  ###  \n #   # \n  ###  \n #   # \n  ###  ", // 8
            "  ###  \n #   # \n  ###  \n     # \n  ###  "  // 9
            };

            Console.WriteLine(digits[number]);
        }
    }
}
