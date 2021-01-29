using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager        //krediye basvuru alacağız..
    {
        //Burada yapılan Method injection yapıyoruz yani bu metotun kullanacağı kredimanagerın ne olacağını yani hangi kredi türü olacağını ve hangi loglayıcı olacağını enjekte ediyoruz.. 
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)            //bu başvuruyu hangi krediye göre yapmam gerektiğini bana söyle demek için elinde herkesin referans numarasını tutan IKerdiManager ı yazdık.. //logger kısmını logları işledikten sonra koyduk..
        {
            //Başvuran bilgilerini değerlendirme
            //Krediyi hesaplayalım


            // KonutKrediManager konutKrediManager = new KonutKrediManager();
            // konutKrediManager.Hesapla();                //böyle yazarsak bu kod çalışır ama tüm başvurular konut kredisi üzerinden hesaplanır.. Tüm başvuruları konut kredisine bağımlı hale getiririm bunu yaparsam...



            //ancak yukarıya başvuru yap parantezine IKrediManager yazarsam başvuruyu kredi bağımsız hale aşağıdaki kodu yazarak getiririz..

            krediManager.Hesapla();         //IKredi bütün kredilerin referans nosunu taşıyor, krediManager da onun burdaki ismi olduğuna göre hangi kredi türünü hesaplamak istiyorsam IKredi o kredinin referans nosu ile çalışır..
                                            //yani artık ben basvuru yap kısmına hangi krediyi gönderirsem bellekte o kredinin referans nosu çalışır..

            loggerService.Log();        //hesaplamayı yaptıktan sonra başvurunun sonunda hangi logger servis gönderilmişse onu logla
        }


        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)    //bana bi liste ver ama bu listenin türü IKrediManager olsun.. //program.cs de gidip listeyi yapalım..
        {
            foreach (var kredi in krediler)         //listedeki herbir kredinin hesabını yap //bundan önce tek bir kredi vardı onu çağırıyoduk ama burda bir liste var.. yani 10 tane gönderilmiş olabilir her birini tek tek dolaş hesapla..
            {
                kredi.Hesapla();
            }


        }







    }
}
