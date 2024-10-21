using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> userNumbers = new List<int>();
        List<int> computerNumbers = new List<int>();
        Random rand = new Random();

        while (true)
        {
            Console.Write("Введите число от 1 до 10: ");
            int userInput;

            if (!int.TryParse(Console.ReadLine(), out userInput) || userInput < 1 || userInput > 10)
            {
                Console.WriteLine("Пожалуйста, введите корректное число от 1 до 10.");
                continue;
            }

            userNumbers.Add(userInput);
            int computerInput = rand.Next(1, 11);
            computerNumbers.Add(computerInput);

            Console.WriteLine($"Компьютер сгенерировал число: {computerInput}");

            if (userInput == computerInput)
            {
                userNumbers.Remove(userInput);
                computerNumbers.Remove(computerInput);
                Console.WriteLine("Числа совпадают");
            }
            else if (userInput % 2 == computerInput % 2)
            {
                if (userInput > computerInput)
                {
                    userNumbers.Add(userInput / 2);
                    Console.WriteLine($"Оба числа одинаковой четности, список увеличен у пользователя {userInput / 2}.");
                }
                else
                {
                    computerNumbers.Add(computerInput / 2);
                    Console.WriteLine($"Оба числа одинаковой четности, список увеличен у компьютера {computerInput / 2}.");
                }
            }
            else
            {
                int userAverage = CalculateAverage(userNumbers);
                int computerAverage = CalculateAverage(computerNumbers);

                if (Math.Abs(userInput - userAverage) < Math.Abs(computerInput - computerAverage))
                {
                    userNumbers.Add(CeilingDivide(userNumbers[userNumbers.Count - 1] + userNumbers[userNumbers.Count - 2], 2));
                    Console.WriteLine($"Числа разных четностей, список увеличен у пользователя {CeilingDivide(userNumbers[userNumbers.Count - 1] + userNumbers[userNumbers.Count - 2], 2)}.");
                }
                else
                {
                    computerNumbers.Add(CeilingDivide(computerNumbers[computerNumbers.Count - 1] + computerNumbers[computerNumbers.Count - 2], 2));
                    Console.WriteLine($"Числа разных четностей, список увеличен у компьютера {CeilingDivide(computerNumbers[computerNumbers.Count - 1] + computerNumbers[computerNumbers.Count - 2], 2)}.");
                }
            }

            if (Sum(userNumbers) >= 100)
            {
                Console.WriteLine("Пользователь достиг суммы 100! Игра окончена.");
                
            }

            if (Sum(computerNumbers) >= 100)
            {
                Console.WriteLine("Компьютер достиг суммы 100! Игра окончена.");
                
            }
        }
    }

    static int Sum(List<int> numbers)
    {
        int sum = 0;
        foreach (var number in numbers)
        {
            sum += number;
        }
        return sum;
    }

    static int CalculateAverage(List<int> numbers)
    {
        if (numbers.Count >= 2)
        {
            return (numbers[numbers.Count - 1] + numbers[numbers.Count - 2]) / 2;
        }
        return 0; 
    }

    static int CeilingDivide(int numerator, int denominator)
    {
        return (numerator + denominator - 1) / denominator; 
    }
}
