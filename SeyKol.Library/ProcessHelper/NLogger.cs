using NLog;
using SeyKol.StudyAnalysis.Library.Interface;

namespace SeyKol.StudyAnalysis.Library.ProcessHelper
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
