/*
 * Øvelse 0 - C# programmering basis tråd øvelser
*/

using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Opgave1
{
    class program
    {
        /// <summary>
        /// Writes the threads name 5 times, the name is retrieved by Thread.CurrentThread.Name
        /// </summary>
        public void WorkThreadFunction()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Thread -> {Thread.CurrentThread.Name}");
            }

        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            program pg = new program();

            // Creates two new threads that runs the WorkThreadFunction method
            Thread thread1 = new Thread(new ThreadStart(pg.WorkThreadFunction));
            Thread thread2 = new Thread(new ThreadStart(pg.WorkThreadFunction));

            // Gives both threads an name
            thread1.Name = "Template thread";
            thread2.Name = "Thread 2";

            // Starts both threads
            thread1.Start();
            thread2.Start();

            // Joins both threads
            thread1.Join();
            thread2.Join();


            // Keeps main method running
            Console.Read();
        }
    }
}
