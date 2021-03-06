﻿using SeyKol.StudyAnalysis.Library.Interface;
using SeyKol.StudyAnalysis.Library.ProcessHelper;

namespace SeyKol.StudyAnalysis.Library.Process
{
    public class LogProcess
    {
        private ILog _log;

        public ILog log
        {
            get { return _log; }
            set { _log = value; }
        }

        /// <summary>
        /// Default NLog kullanılacak
        /// </summary>
        public LogProcess()
        {
            _log = new NLogger();
        }

        public LogProcess(ILog log)
        {
            _log = log;
        }
    }
}
