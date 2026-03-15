using System;
using SmartTaskApp.Models;
using SmartTaskApp.Services;

namespace SmartTaskApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = TaskManager.Instance;

            while(true)
            {
                Console.WriteLine("SmartTask Menu");
                Console.WriteLine("1 Add Task");
                Console.WriteLine("2 Complete Task");
                Console.WriteLine("3 Delete Task");
                Console.WriteLine("4 View Tasks");
                Console.WriteLine("5 Exit");

                string choice = Console.ReadLine();

                switch(choice)
                {
                    case "1":
                        Console.Write("Task Title: ");
                        string title = Console.ReadLine();
                        manager.AddTask(title, Category.School);
                        break;

                    case "2":
                        Console.Write("Task Index: ");
                        manager.CompleteTask(int.Parse(Console.ReadLine()));
                        break;

                    case "3":
                        Console.Write("Task Index: ");
                        manager.DeleteTask(int.Parse(Console.ReadLine()));
                        break;

                    case "4":
                        int i=0;
                        foreach(var t in manager.GetTasks())
                        {
                            Console.WriteLine($"{i}: {t.Title} [{t.Category}] Completed:{t.IsCompleted}");
                            i++;
                        }
                        break;

                    case "5":
                        return;
                }
            }
        }
    }