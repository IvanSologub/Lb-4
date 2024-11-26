using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите целое число N (> 2): ");
        int N;

        // Проверка на корректность ввода
        while (!int.TryParse(Console.ReadLine(), out N) || N <= 2)
        {
            Console.Write("Пожалуйста, введите корректное целое число больше 2: ");
        }

        double[] numbers = new double[N];

        // Ввод вещественных чисел
        Console.WriteLine("Введите " + N + " вещественных чисел:");
        for (int i = 0; i < N; i++)
        {
            while (!double.TryParse(Console.ReadLine(), out numbers[i]))
            {
                Console.Write("Пожалуйста, введите корректное вещественное число: ");
            }
        }

        // Проверка на пилообразность
        for (int i = 1; i < N - 1; i++)
        {
            if (!((numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1]) || 
                  (numbers[i] < numbers[i - 1] && numbers[i] < numbers[i + 1])))
            )
            {
                Console.WriteLine($"Набор не является пилообразным. Номер первого элемента, не являющегося зубцом: {i + 1}");
                return;
            }
        }

        // Если набор является пилообразным
        Console.WriteLine("Набор является пилообразным. Вывод: 0");
    }
}
