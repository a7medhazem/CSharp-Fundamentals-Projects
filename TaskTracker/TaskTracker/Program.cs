namespace TaskTracker
{
    internal class Program
    {
        static string[] Tasks = new string[100];
        static uint TaskIndex = 0;

        static void Main(string[] args)
        {
            //system options
            // 0. View Options
            // 1. add task
            // 2. view all tasks
            // 3. mark task complete
            // 4. remove task
            // 5. exit
            Console.WriteLine("===========================");
            Console.WriteLine("Welcome to My Task Tracker");
            Console.WriteLine("===========================");

            ViewOptions();

            while (true)
            {
                Console.WriteLine("Enter your Choice from 0 to 5");


                string UserChoice = Console.ReadLine();

                switch (UserChoice)
                {
                    case "0":
                        ViewOptions();
                        break;
                    case "1":
                        AddTask();
                        break;
                    case "2":
                        ViewTasks();
                        break;
                    case "3":
                        //mark task completed
                        MarkComplete();
                        break;
                    case "4":
                        RemoveTask();
                        break;
                    case "5":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please Enter Number from (0) to (5) only...");
                        break;

                }
            }

        }
        private static void ViewOptions()
        {

            Console.WriteLine("===========================");
            Console.WriteLine("[0]-View Options");
            Console.WriteLine("[1]-Add Task");
            Console.WriteLine("[2]-View Tasks");
            Console.WriteLine("[3]-Mark Task complete");
            Console.WriteLine("[4]-Remove Task");
            Console.WriteLine("[5]-Exit");
            Console.WriteLine("===========================");
        }
        private static void AddTask()
        {
            if (TaskIndex >= Tasks.Length)
            {
                Console.WriteLine("Task list is full.");
                return;
            }
            Console.WriteLine("Enter your Task");
            string TaskTittle = Console.ReadLine();
            Tasks[TaskIndex] = TaskTittle;
            TaskIndex++;

            Console.WriteLine("Task added");

        }
        private static void ViewTasks()
        {
            if (TaskIndex == 0)
            {
                Console.WriteLine("No tasks to show.");
                return;
            }
            else
            {
                Console.WriteLine("Task List :");

                for (int i = 0; i < TaskIndex; i++)
                {
                    Console.WriteLine($"{i + 1}. Task Title : {Tasks[i]}");
                }
            }
        }

        private static void MarkComplete()
        {
            // Checking if there are any available tasks

            if (TaskIndex == 0)
            {
                Console.WriteLine("No tasks available.");
                return;
            }
            Console.WriteLine($"Enter Task Number to mark it:");
            if (int.TryParse(Console.ReadLine(), out int TaskNum))
            {
                int index = TaskNum - 1;//store actual index

                if (TaskNum <= 0 || TaskNum > TaskIndex)
                {
                    Console.WriteLine($"number {TaskNum} is  out of the range");
                }
                else
                {
                    if (!Tasks[index].EndsWith("--> completed"))
                    {
                        Tasks[index] += " --> completed";
                        Console.WriteLine($"Task number {index + 1} is marked complete.");
                    }
                    else
                    {
                        Console.WriteLine("this task is marked before.");

                    }
                }

            }


        }

        private static void RemoveTask()
        {
            // Checking if there are any available tasks
            if (TaskIndex == 0)
            {
                Console.WriteLine("No tasks available.");
                return;
            }
            //start rmoving
            Console.WriteLine("Enter Task Number to delete:");
            if (int.TryParse(Console.ReadLine(), out int TaskNum))
            {
                if (TaskNum <= 0 || TaskNum > TaskIndex)
                {
                    Console.WriteLine($"number {TaskNum} is  out of the range");
                }
                else if (TaskNum == TaskIndex)
                {
                    TaskIndex--;
                    Console.WriteLine("Task is deleted");

                }
                else
                {
                    TaskNum--;
                    for (int i = TaskNum; i < TaskIndex - 1; i++)
                    {
                        Tasks[i] = Tasks[i + 1];
                    }
                    TaskIndex--;
                    Console.WriteLine("Task is deleted");
                }
            }
        }

    }
}
