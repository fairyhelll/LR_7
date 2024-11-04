using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        // Запускаємо три асинхронні завдання паралельно
        Task task1 = Task.Run(Method1);
        Task task2 = Task.Run(Method2);
        Task task3 = Task.Run(Method3);

        // Очікуємо завершення всіх завдань
        await Task.WhenAll(task1, task2, task3);

        Console.WriteLine("Усі завдання виконано.");
    }

    static void Method1()
    {
        Console.WriteLine("Запуск Method1...");
        Thread.Sleep(3000); // Імітація тривалої роботи (3 секунди)
        Console.WriteLine("Method1 завершено.");
    }

    static void Method2()
    {
        Console.WriteLine("Запуск Method2...");
        Thread.Sleep(2000); // Імітація тривалої роботи (2 секунди)
        Console.WriteLine("Method2 завершено.");
    }

    static void Method3()
    {
        Console.WriteLine("Запуск Method3...");
        Thread.Sleep(1000); // Імітація тривалої роботи (1 секунда)
        Console.WriteLine("Method3 завершено.");
    }
}
