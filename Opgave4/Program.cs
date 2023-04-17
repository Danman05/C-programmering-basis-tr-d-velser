/*
 * Øvelse 4 - C# programmering basis tråd øvelser
*/
namespace Opgave4
{
    internal class Program
    {
        /// <summary>
        /// char to hold the currentChar, this is set by the inputThread using the method GetChar
        /// </summary>
        static char ch = '*';
        static void Main(string[] args)
        {

            // Two threads that is used for input and output
            Thread inputThread = new Thread(GetChar);
            Thread outputThread = new Thread(DisplayChar);

            inputThread.Start();
            outputThread.Start();

        }

        /// <summary>
        /// Method that uses ConsoleKeyInfo to retrieve the pressed key in 
        /// </summary>
        static void GetChar()
        {
            while (true)
            {
                char inputChar = Console.ReadKey().KeyChar;
                ch = inputChar;
            }
        }

        /// <summary>
        /// Method that writes the currentChar to the console every 25 miliseconds. Used by the outputThread
        /// </summary>
        static void DisplayChar()
        {
            while (true)
            {
                Console.Write(ch);
                Thread.Sleep(25);
            }
        }
    }
}