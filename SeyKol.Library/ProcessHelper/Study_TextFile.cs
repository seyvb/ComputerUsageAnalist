using System.IO;
using System.Net.Mime;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using SeyKol.StudyAnalysis.Library.Interface;
using SeyKol.StudyAnalysis.Library.Manager;

namespace SeyKol.StudyAnalysis.Library.ProcessHelper
{
    public class Study_TextFile:IStudy
    {
        public void WriteDetail(string fileName, string msj)
        {
            var setting = new Setting();
            var directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase).Replace("file:\\","");
            var filePath = $"{directory}\\{setting.StudyLogFolder}\\{fileName}";
            FileManager.Write(filePath, Encoding.UTF8.GetBytes(msj));
        } 
    }
}
