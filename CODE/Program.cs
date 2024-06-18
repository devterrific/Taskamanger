using System;

class Program
{
    static void Main(string[] args)
    {
        
        Task task1 = new Task(1, "Implementieren der Task-Klasse");
        Task task2 = new Task(2, "Implementieren der TaskManager-Klasse");

        TaskManager taskManager = new TaskManager();

       
        taskManager.AddTask(task1);
        taskManager.AddTask(task2);

       
        Console.WriteLine("All Tasks:");
        taskManager.DisplayTasks();

       
        taskManager.MarkTaskAsCompleted(1);

       
        taskManager.DisplayCompletedTasks();

        Console.ReadLine(); 
    }
}
