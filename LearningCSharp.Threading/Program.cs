using System;
using System.Threading.Tasks;

namespace LearningCSharp.Threading
{
    class Program
    {
       static void Main(string[] args)
        {
            Console.WriteLine("Beginning of Main Program");
            int timer = 0;
            Task task = Task.Run(() => timer = SpinTask());
            Console.WriteLine("Other Parts of Main Program");
            Console.WriteLine(".........................");
            task.Wait();
            Console.WriteLine($"Timer is {timer}");
            Console.WriteLine("End of  Main Program");
        }

        public static int SpinTask() {
            int timer = 100;
            Console.WriteLine("Beginning of SpinTask Program");
            Task.Delay(100).Wait(); 
            Console.WriteLine("End of SpinTask Program");
            return timer;
        }
    }
}
