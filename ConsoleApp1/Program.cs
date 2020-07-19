using ConsoleApp1.Process;
using System;
using System.Timers;
using SeyKol.Library.Process;
using SeyKol.Library.ProcessHelper;
namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            var trace = ComputerTraceProcess.CreateComputerTrace();
            var log = new LogProcess().log;

            var t = new Timer(1000);
            t.Start();
            t.Elapsed += delegate
            {
                try
                {

                    //var ct= ComputerTraceProcess.CreateComputerTrace();

                    //var lst = ct.GetLastInputTime();
                    //var tm = ct.GetIdleTime();

                    //Console.WriteLine($"Last : {lst},MiliSecond : {tm}");

                    ////Console.WriteLine(GetLastUserInput.GetLastUserInput.GetLastInputTime());
                    ////Console.WriteLine(GetLastUserInput.GetIdleTickCount());

                    string msj = $"Last : {trace.GetLastInputTime()},MiliSecond : {trace.GetIdleTime()}";

                    Console.WriteLine(msj);
                    log.WriteLog(msj); 
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
