using System.IO;

namespace SeyKol.StudyAnalysis.Library.Manager
{
    public static class FileManager
    {
        public static void Write(string filePath,byte[] msj)
        {
            var fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
            var sw = new StreamWriter(fs);
            if(fs.CanWrite)
                fs.Write(msj,0,msj.Length);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
    }
}
