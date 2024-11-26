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

        // Переменная для хранения перевернутого числа
        int reversedNumber = 0;

        // Переворот числа
        while (N > 0)
        {
            // Получаем последнюю цифру
            int lastDigit = N % 10;
            // Добавляем ее к перевернутому числу
            reversedNumber = reversedNumber * 10 + lastDigit;
            // Убираем последнюю цифру из N
            N /= 10;
        }

        // Вывод результата
        Console.WriteLine($"Перевернутое число: {reversedNumber}");
    }
}
