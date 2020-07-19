using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeyKol.StudyAnalysis.Library.Interface;
using SeyKol.StudyAnalysis.Library.ProcessHelper;

namespace SeyKol.StudyAnalysis.Library.Process
{
    class ComputerTraceProcess
    {
        //Hangi yöntemin kullanılacağı belirleniyor.
        public static IComputerTrace CreateComputerTrace()
        {
            IComputerTrace retVal = new GetLastUserInput.LastUserInput();

            return retVal;
        }
    }
}
