using System;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            //Counter using while loop
            int counter = 0;
            int limit = 10; 
            while(counter <= limit)
            {
                Console.WriteLine("Counter is at: " + counter);
                counter++;
            }
        }
    }
}
