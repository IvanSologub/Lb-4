using System;

class Program
{
    static void Main()
    {
        // Запрос числа N у пользователя
        Console.Write("Введите целое число N (> 0): ");
        int N;
        
        // Проверка корректности ввода
        while (!int.TryParse(Console.ReadLine(), out N) || N <= 0)
        {
            Console.Write("Пожалуйста, введите корректное целое число больше 0: ");
        }

        // Вычисление суммы
        double sum = 0.0;
        for (int i = 1; i <= N; i++)
        {
            sum += 1.0 / i; // Суммируем 1/i
        }

        // Вывод результата
        Console.WriteLine($"Сумма ряда от 1 до 1/{N} равна: {sum}");
    }
}
