using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        // Запускаем три различные асинхронные операции
        Task task1 = ProcessDataAsync("Resource 1", 3000);
        Task task2 = ProcessDataAsync("Resource 2", 2000);
        Task task3 = ProcessDataAsync("Resource 3", 1000);

        // Дожидаемся завершения всех трех задач
        await Task.WhenAll(task1, task2, task3);

        Console.WriteLine("Все асинхронные задачи выполнены.");
    }

    static async Task ProcessDataAsync(string resourceName, int delay)
    {
        // Вывод информации о начале работы
        Console.WriteLine($"Начало обработки данных из {resourceName}");

        // Имитация длительной асинхронной операции
        await Task.Delay(delay);

        // Вывод информации о завершении работы
        Console.WriteLine($"Обработка данных из {resourceName} завершена.");
    }
}