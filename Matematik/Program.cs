using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            //ben diyelimki birden fazla ekranda toplama yapıcam.. 
            //ben zaten toplama işlemi yapan bir metot oluşturmuştum.. (DortIslem)..
            //o metot DortIslem classında olduğu için benim o classtan bir tane örnek oluşturmam lazım..

            DortIslem dortIslem = new DortIslem();
            dortIslem.Topla(5, 6);

            //başka bir sayfada..

            dortIslem.Topla(6, 9);

            //parametreler (5-6-9) değişkenlik gösterebilir.. aynı urun adı gibi..


        }
    }
}
