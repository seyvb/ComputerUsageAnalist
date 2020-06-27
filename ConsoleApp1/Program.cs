using ConsoleApp1.Process;
using System;
using System.Timers;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            var t = new Timer(1000);
            t.Start();
            t.Elapsed += delegate
            {
                try
                {
                    var ct= ComputerTraceProcess.CreateComputerTrace();

                    var lst = ct.GetLastInputTime();
                    var tm = ct.GetIdleTime();

                    Console.WriteLine($"Last : {lst},MiliSecond : {tm}");

                    //Console.WriteLine(GetLastUserInput.GetLastUserInput.GetLastInputTime());
                    //Console.WriteLine(GetLastUserInput.GetIdleTickCount());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                
            };
            Console.ReadLine();
        }
    }
}
