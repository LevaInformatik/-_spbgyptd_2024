using System;

class Program
{
    public class ArrayProcessor
    {
        private int[] numbers;

        public ArrayProcessor(int[] inputNumbers)
        {
            numbers = inputNumbers;
        }

        public double CalculateAverage()
        {
            double sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum / numbers.Length;
        }

        public void ReplaceNumbers()
        {
            double average = CalculateAverage();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > average)
                {
                    numbers[i] = 1;
                }
                else
                {
                    numbers[i] = 0;
                }
            }
        }

        public void DisplayArray()
        {
            Console.WriteLine("Изменённый массив:");
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Введите числа через пробел:");
        string input = Console.ReadLine();
        string[] stringNumbers = input.Split(' ');

        int[] numbers = Array.ConvertAll(stringNumbers, int.Parse);

        ArrayProcessor arrayProcessor = new ArrayProcessor(numbers);
        arrayProcessor.ReplaceNumbers();
        arrayProcessor.DisplayArray();
    }
}
