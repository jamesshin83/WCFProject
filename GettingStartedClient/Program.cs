using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GettingStartedClient.GettingStarted;
using log4net;
using log4net.Config;
using System.Threading;
using System.Diagnostics;

namespace GettingStartedClient
{
    class Program
    {
        private readonly static ILog Log = LogManager.GetLogger(typeof(Program));
        static void Main(string[] args)
        {
            XmlConfigurator.Configure();

            //Step 1: Create an instance of the WCF proxy.

            // Step 2: Call the service operations.
            // Call the Add service operation.
            int[] numbers = new int[50];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i;
            }

            Console.WriteLine("Threads: {0}", Process.GetCurrentProcess().Threads.Count);

            Log.InfoFormat("Starting thread loop...");
            Parallel.ForEach(numbers, new ParallelOptions { MaxDegreeOfParallelism = 5 }, (number) =>
            {
                CalculatorClient client = new CalculatorClient();
                Stopwatch sw = new Stopwatch();
                sw.Start();
                double result = client.add(number, number);
                sw.Stop();

                Log.InfoFormat("Add({0}, {0}) = {1}. Thread {2} took {3}ms", number, result, Thread.CurrentThread.Name, sw.ElapsedMilliseconds);
                client.Close();
            });
            Log.InfoFormat("Finishing thread loop...");
            //// Call the Subtract service operation.
            //value1 = 145.00D;
            //value2 = 76.54D;
            //result = client.Subtract(value1, value2);
            //Console.WriteLine("Subtract({0},{1}) = {2}", value1, value2, result);
            //Log.InfoFormat("Subtract({0},{1}) = {2}", value1, value2, result);

            //// Call the Multiply service operation.
            //value1 = 9.00D;
            //value2 = 81.25D;
            //result = client.Multiply(value1, value2);
            //Console.WriteLine("Multiply({0},{1}) = {2}", value1, value2, result);
            //Log.InfoFormat("Multiply({0},{1}) = {2}", value1, value2, result);

            //// Call the Divide service operation.
            //value1 = 22.00D;
            //value2 = 7.00D;
            //result = client.Divide(value1, value2);
            //Console.WriteLine("Divide({0},{1}) = {2}", value1, value2, result);
            //Log.InfoFormat("Divide({0},{1}) = {2}", value1, value2, result);

            //Step 3: Closing the client gracefully closes the connection and cleans up resources.

        }
    }

    class CustomData
    {
        public int Number { get; set; }
    }
}
