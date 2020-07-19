namespace SeyKol.StudyAnalysis.Library.Interface
{
    public interface IStudy
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName">Dosya Adı yyyyMMdd_HHSS</param>
        /// <param name="msj">Usage;Idled</param>
        void WriteDetail(string fileName,string msj);
    }
}
