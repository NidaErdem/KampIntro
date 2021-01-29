using System;

namespace OOP3
{
    class FilebaseLoggerService : ILoggerService 
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı.");                     //buda 2. alternatif.. Şimdilik 2 tane loglama sistemim var..                                                      
        }
    }
}
