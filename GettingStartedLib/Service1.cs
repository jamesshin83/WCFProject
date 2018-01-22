using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace GettingStartedLib
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class CalculatorService : ICalculator
    {
        private readonly ILog Log = LogManager.GetLogger(typeof(CalculatorService));
        public double add(double n1, double n2)
        {
            double result = n1 + n2;
            Console.WriteLine("Received Add({0},{1})", n1, n2);
            Log.InfoFormat("Received Add({0},{1})", n1, n2);
            // Code added to write output to the console window.
            Console.WriteLine("Return: {0}", result);
            Log.InfoFormat("Return: {0}", result);

            Thread.Sleep(5000);
            return result;
        }

        public double Subtract(double n1, double n2)
        {
            double result = n1 - n2;
            Console.WriteLine("Received Subtract({0},{1})", n1, n2);
            Log.InfoFormat("Received Subtract({0},{1})", n1, n2);
            Console.WriteLine("Return: {0}", result);
            Log.InfoFormat("Return: {0}", result);
            return result;
        }

        public double Multiply(double n1, double n2)
        {
            double result = n1 * n2;
            Console.WriteLine("Received Multiply({0},{1})", n1, n2);
            Log.InfoFormat("Received Multiply({0},{1})", n1, n2);
            Console.WriteLine("Return: {0}", result);
            Log.InfoFormat("Return: {0}", result);
            return result;
        }

        public double Divide(double n1, double n2)
        {
            double result = n1 / n2;
            Console.WriteLine("Received Divide({0},{1})", n1, n2);
            Log.InfoFormat("Received Divide({0},{1})", n1, n2);
            Console.WriteLine("Return: {0}", result);
            Log.InfoFormat("Return: {0}", result);
            return result;
        }
    }
}
