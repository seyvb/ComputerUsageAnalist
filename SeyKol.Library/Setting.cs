using System;
using System.Configuration;
using NLog.Internal;

namespace SeyKol.StudyAnalysis.Library
{
    public class Setting
    {
        public string StudyLogFolder
        {
            get
            {
                return System.Configuration.ConfigurationManager.AppSettings["StudyLogFolder"].ToString();
            }
        }
    }
}
