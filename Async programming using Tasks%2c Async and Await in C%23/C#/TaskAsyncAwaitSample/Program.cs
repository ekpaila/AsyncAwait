using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskAsyncAwaitSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running Async code...");
            
            Task<bool> result = DoWorkAsyc();
            Console.WriteLine("Async method called.\nResult will display once available from the async method.");

            result.Wait();

            Console.WriteLine(result.Result);
            
            Console.WriteLine("Press any key to exit: ");
            Console.ReadKey();
        }

        /// <summary>
        /// optimized DoWork method - runs aync!
        /// </summary>
        public static async Task<bool> DoWorkAsyc()
        {
            // use await here, like so:
            return await Task.Run(() => ProcessJob());
        }

        private static bool ProcessJob()
        {
            //long running work code goes here
            Thread.Sleep(5000);

            return true;
        }
    }
}
