namespace SeyKol.StudyAnalysis.Library.Interface
{
    interface IComputerTrace
    {
        /// <summary>
        /// Bilgisayarın boşta kalma zamanını milisaniye cinsinden döndürür
        /// </summary>
        /// <returns></returns>
        uint GetIdleTime();

        /// <summary>
        /// Bilgisayarın son kullanıldığı zamanı döndürür
        /// </summary>
        /// <returns></returns>
        uint GetLastInputTime();
    }
}
