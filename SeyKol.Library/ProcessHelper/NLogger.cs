using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using SeyKol.StudyAnalysis.Library.Interface;

namespace SeyKol.Library.ProcessHelper
{
    public class NLogger: ILog
    {
        private static Logger _logger = LogManager.GetCurrentClassLogger();

        public void WriteLog(string message)
        {
            _logger.Info(message);
        }
    }
}
