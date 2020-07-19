using SeyKol.StudyAnalysis.Library.Interface;
using SeyKol.StudyAnalysis.Library.ProcessHelper;

namespace SeyKol.StudyAnalysis.Library.Process
{
    public class StudyProcess
    {
        private IStudy _study;

        public IStudy study => _study;

        public StudyProcess()
        {
            _study = new Study_TextFile();
        }

        public StudyProcess(IStudy study)
        {
            _study = study;
        }
    }
}
