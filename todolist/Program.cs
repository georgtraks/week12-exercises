using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace todolist
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> todofromfile = new List<string>();
            string todofilepath = @"C:\Users\opilane\samples\todolist.txt";

            todofromfile = File.ReadAllLines(todofilepath).ToList();

            

            foreach(string task in todofromfile)
            {
                Console.WriteLine(task);
            }
                bool loopactive = true;

            while(loopactive)
            {
                Console.WriteLine("would you like to add a task? y/n");
                char userinput = Convert.ToChar(Console.ReadLine().ToLower());

                if(userinput == 'y')
                {
                    Console.WriteLine("enter a task");
                    string usertask = Console.ReadLine();
                    todofromfile.Add(usertask);
                    Console.WriteLine($"task {usertask} added.");


                }
                else
                {
                    Console.WriteLine("take care!");
                    loopactive = false;
                }
            }
            File.WriteAllLines(todofilepath, todofromfile.ToArray());

        }
    }
}
