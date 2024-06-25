using System;
using System.Collections.Generic;
 
 
public class TaskManager
{
    private List<Task> tasks;
    /* Konstruktor */
    public TaskManager()
    {
        tasks = new List<Task>();
    }
 
    /* Diese Methode fuegt Task hinzu */
    public void AddTask(Task task)
    {
        tasks.Add(task);
    }
 
   
    public void DisplayTasks()
    {
        foreach (var task in tasks)
        {
            Console.WriteLine($"Task ID: {task.Id}, Description: {task.Description}, Completed: {task.Completed}");
        }
    }
 
    /* In dieser Methode kann man Task als Fertig Markieren*/
    public void MarkTaskAsCompleted(int taskId)
    {
        var task = tasks.Find(t => t.Id == taskId);
        if (task != null)
        {
            task.Completed = true;
            Console.WriteLine($"Task ID {taskId} marked as completed.");
        }
        else
        {
            Console.WriteLine($"Task with ID {taskId} not found.");
        }
    }
 
   
    public void DisplayCompletedTasks()
    {
        var completedTasks = tasks.FindAll(t => t.Completed);
        Console.WriteLine("Completed Tasks:");
        foreach (var task in completedTasks)
        {
            Console.WriteLine($"Task ID: {task.Id}, Description: {task.Description}");
        }
    }
}
 