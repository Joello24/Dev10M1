using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Backend
{
    internal class TaskManager
    {
        public static void Run() {
            string[] taskList = new string[5];
            bool run = true;
            while (run == true)
            {
                switch (Select())
                {
                    case "1":
                        ViewTaskList(taskList);
                        break;
                    case "2":
                        taskList = AddTask(taskList);
                        break;
                    case "3":
                        taskList = RemoveTask(taskList);
                        break;
                    case "q":
                        run = false;
                        break;
                }
            }
        }
        private static string Select()
        {
            Console.WriteLine("TASK LIST OPTION MENU");
            Console.WriteLine("----------------");
            Console.WriteLine("1. View List");
            Console.WriteLine("2. Add a Task");
            Console.WriteLine("3. Remove a Task");
            Console.WriteLine("\nPress q to quit");
            Console.WriteLine("----------------");
            Console.Write("Enter Choice: ");
            return Console.ReadLine();
        }
        private static String[] AddTask(String[] taskList)
        {
            Console.WriteLine("Enter Task: ");
            String temp = Console.ReadLine();
            for (int i = 0; i < taskList.Length; i++)
            {
                if (taskList[i] == temp)
                {
                    Console.WriteLine("It's on the list!");
                    break;
                }
                if (string.IsNullOrEmpty(taskList[i]))
                {
                    taskList[i] = temp;
                    break;
                }
            }
            return taskList;
        }
        private static void ViewTaskList(String[] taskList)
        {
            for (int i = 0; i < taskList.Length; i++)
            {
                if (string.IsNullOrEmpty(taskList[i]) == false)
                {
                    Console.WriteLine($"{i + 1}: {taskList[i]}");
                }
            }
        }
        private static string[] RemoveTask(String[] taskList) {
            int i = 0;
            Console.WriteLine("Task to delete: ");
            string temp = Console.ReadLine();
            foreach (String t in taskList)
            {
                if (t == temp) 
                {
                    taskList = taskList.Where(e=> e != temp).ToArray();
                }
            }
            return taskList;
        }
    }
}
