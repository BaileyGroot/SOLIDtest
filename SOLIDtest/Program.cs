using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SOLIDtest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Grootrix Horserace 2021");
            Thread.Sleep(2000);
            Console.WriteLine("There will be 8 horses competing!");
            Thread.Sleep(2000);
            Console.WriteLine("Bedding Opened!");
            Thread.Sleep(10000);
            Console.WriteLine("Bedding Closed!");
            Thread.Sleep(2000);
            Console.WriteLine("Race Started");

            Random random = new Random();
            Participant p = new Participant();
            p.listHorse();

            Console.WriteLine("In the lead is: " + p);

            // Horse 1-8: Is in the lead
            // Wait 2
            // Horse 1-8: Is in the lead
            // Wait 2
            // Horse 1-8: Is in the lead
            // Wait 2
            // Horse 1-8: Is in the lead
            // Wait 2
            // Horse 1-8: Is in the lead
            // Wait 2
            // Horse 1-8: Is in the lead

            // Horse 1-8: Have won.
            // Horse stats printed

        }
    }
}
