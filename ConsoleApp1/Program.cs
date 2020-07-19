using ConsoleApp1.Process;
using System;
using System.Timers;
using SeyKol.StudyAnalysis.Library.Process;


namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            var trace = ComputerTraceProcess.CreateComputerTrace();
            var log = new LogProcess().log;
            var textFile = new StudyProcess().study;

            var t = new Timer(1000);
            t.Start();
            t.Elapsed += delegate
            {
                t.Stop();
                try
                {

                    //var ct= ComputerTraceProcess.CreateComputerTrace();

                    //var lst = ct.GetLastInputTime();
                    //var tm = ct.GetIdleTime();

                    //Console.WriteLine($"Last : {lst},MiliSecond : {tm}");

                    ////Console.WriteLine(GetLastUserInput.GetLastUserInput.GetLastInputTime());
                    ////Console.WriteLine(GetLastUserInput.GetIdleTickCount());

                    var msj = $"Last : {trace.GetLastInputTime()},MiliSecond : {trace.GetIdleTime()}";

                    Console.WriteLine(msj);
                    log.WriteLog(msj);

                    textFile.WriteDetail("test.txt", $"Merhaba Dünya {DateTime.Now.Millisecond}");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                finally
                {
                    t.Start();
                }
            };
            Console.ReadLine();
        }
    }
}
