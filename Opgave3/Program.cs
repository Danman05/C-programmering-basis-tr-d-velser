/*
 * Opgave 3 - C# programmering basis tråd øvelser
*/
namespace Opgave3
{
    internal class Program
    {
        /// <summary>
        /// Holds the amount of alarms, an alarm is added when the temp is under -20 or above 120
        /// </summary>
        static int numberOfAlarms;
        static void Main(string[] args)
        {
            // Creates and starts a thread to generate random numbers between -20 to 120
            Thread thread = new Thread(GenerateRandomTemp);
            thread.Start();

            // The main thread checks if the other thread is alive every 10 seconds
            while (true)
            {
                if (!thread.IsAlive)
                {
                    Console.WriteLine("Alarm-tråd termineret!");
                    break;
                }
                Thread.Sleep(10000);
            }
            thread.Join();

            Console.Read();
        }

        /// <summary>
        /// void method to generate random temperatures between -20 and 120 , until alarms is greater or equals 3 
        /// </summary>
        static private void GenerateRandomTemp()
        {
            Random rnd = new Random();

            while (true)
            {
                int tempReading = rnd.Next(-20, 121);

                Console.WriteLine(tempReading);

                // Increments numberOfAlarms each time the statement is true
                if ((tempReading <= 0) || tempReading >= 100)
                {
                    numberOfAlarms++;
                }

                if (numberOfAlarms >= 3)
                {
                    break;
                }
                Thread.Sleep(2000);
            }
        }
    }
}