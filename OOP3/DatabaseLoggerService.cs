using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DatabaseLoggerService : ILoggerService      //:ILoggerService i kendim yazdım, diyorum ki; sen aslında bir ILoggerService alternatifisin.. Lambaya tıklayıp zorunlu metotları çağırıyoruz..
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı.");       //simüle ettik böyle..                                                                            
        }
    }
 }
