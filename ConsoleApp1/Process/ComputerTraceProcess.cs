using ConsoleApp1.Interface;
using ConsoleApp1.ProcessHelper;

namespace ConsoleApp1.Process
{
    class ComputerTraceProcess
    {
        //Hangi yöntemin kullanılacağı belirleniyor.
        public static IComputerTrace CreateComputerTrace()
        {
            IComputerTrace retVal = new LastUserInput();

            return retVal;
        }
    }
}
