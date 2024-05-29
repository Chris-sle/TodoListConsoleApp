using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoListConsoleApp
{
    internal class start
    {
        private List<task> tasklist = new List<task>()
        {
            new task("Noe", "Noenoenoe"),
            new task("noe Annet", "Noe mere!!")
        };
        public void Run()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to your To-do-list");
                Console.WriteLine("1. View tasks");
                Console.WriteLine("2. Add tasks");
                Console.WriteLine("3. Remove tasks");
                string userInput = Console.ReadLine();

                switch(userInput)
                {
                    case "1":
                        Viewtasks();
                        break;
                    case "2":
                        Addtasks();
                        break;
                    case "3":
                        Removetasks();
                        break;
                    default:
                        Console.WriteLine("Option not available");
                        break;
                }
            }
        }

        private void Viewtasks()
        {
            Console.Clear();
            Console.WriteLine("Write ID of task to view");
            Console.WriteLine("Your tasks:");
            for (int i = 0; i < tasklist.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasklist[i].getTaskName()}");
            }
            string userInput = Console.ReadLine();
            if (userInput != "")
            {
                int number = Convert.ToInt32(userInput);
                displayTask(tasklist[number - 1]);
            }
        }

        private void displayTask(task task)
        {
            Console.Clear();
            Console.WriteLine($"Name: {task.getTaskName()}");
            Console.WriteLine($"Description: {task.getDescription()}");
            Console.ReadKey(true);
        }


        private void Addtasks()
        {
            Console.Clear();
            Console.WriteLine("What's the name of your task?");
            string taskname = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Please enter a description of your task");
            string taskdesc = Console.ReadLine();
            tasklist.Add(new task(taskname, taskdesc));
            Console.Clear();
            Console.WriteLine("Task successfully added!");
            Console.WriteLine("(Press any key to continue)");
            Console.ReadKey(true);

        }

        private void Removetasks()
        {
            Console.WriteLine("Select a task to remove");

            for (int i = 0; i < tasklist.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasklist[i].getTaskName()}");
            }
            string userReply = Console.ReadLine();
            int number = Convert.ToInt32(userReply);
            tasklist.RemoveAt(number - 1);
            Console.WriteLine("(Press any key to continue)");
            Console.ReadKey(true);
        }
    }
}
