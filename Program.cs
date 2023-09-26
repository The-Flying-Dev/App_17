namespace ToDoList;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to your To Do List Program!");

        // Declare List
        List<string> taskList = new List<string>();

        // Adding values to List using Add() method with item placed inside parenthesis
        taskList.Add("run");
        taskList.Add("walk");
        taskList.Add("jog");
        taskList.Add("hike");
        taskList.Add("breakfast");
        taskList.Add("lunch");
        taskList.Add("sprint");

        // Declare string variable to be used for user input
        string choice = "";

        while (choice != "e")
        {
            Console.WriteLine("\nWhat would you like to do?");
            Console.WriteLine("Enter 1 to add a task to the list.");
            Console.WriteLine("Enter 2 to remove a task from the list.");
            Console.WriteLine("Enter 3 to view the list.");
            Console.WriteLine("Enter e to exit the program. \n");

            choice = Console.ReadLine();

            // Add task
            if (choice == "1")
            {
                Console.Write("Enter the name of the task to add to add to the list. ");
                string task = Console.ReadLine();
                taskList.Add(task);
                Console.WriteLine("Task added to the list.");
            }
            // Remove task
            else if (choice == "2")
            {
                // Loop through List to see current items
                for (int i = 0; i < taskList.Count; i++)
                {
                    Console.WriteLine(i + " : " + taskList[i]);
                }

                Console.Write("Enter the number of the task to remove. ");

                // Stores Integer choice in variable after Converting String to Integer
                int taskNumber = Convert.ToInt32(Console.ReadLine());

                // List method removes item using it's index placed inside the parenthesis
                taskList.RemoveAt(taskNumber);
            }
            // View list
            else if (choice == "3")
            {
                Console.WriteLine("The current tasks in the To Do List are : ");

                // Loop through List using foreach
                foreach (string item in taskList)
                {
                    Console.WriteLine(item);
                }

                // for (int i = 0; i < taskList.Count; i++)
                // {
                //     Console.WriteLine(taskList[i]);
                // }
            }
            // Once entered the While loop's condition is no longer true so program will exit
            else if (choice == "e")
            {
                Console.WriteLine("Exiting the program.");
            }
            else
            {
                Console.WriteLine("Invalid option, try again.");
            }
        }

        Console.WriteLine("Thanks for using the To Do List Program");
        Console.ReadLine();
    }
}
