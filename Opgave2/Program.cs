/*
 * Øvelse 1 & 2 - C# programmering basis tråd øvelser
*/
namespace Opgave2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create two new threads and give names
            Thread thread1 = new Thread(ThreadFunction);
            Thread thread2 = new Thread(ThreadFunction);

            thread1.Name = "First";
            thread2.Name = "Second";

            // Starts & joins the two threads
            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();


            Console.Read();
        }

        /// <summary>
        /// Writes to the console 5 times
        /// depending on the name of the thread, the output will be different
        /// </summary>
        static public void ThreadFunction()
        {
            for (int i = 0; i < 5; i++)
            {
                if (Thread.CurrentThread.Name == "First")
                    Console.WriteLine("C#-trådning er nemt!");

                else if (Thread.CurrentThread.Name == "Second")
                    Console.WriteLine("Også med flere tråde...");

                else
                    Console.WriteLine("Thread name not found");

                Thread.Sleep(1000);
            }
        }
    }
}