using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class MusteriManager
    {
        //İş sınıflarıdır.. //business classes

        public void Ekle(Musteri musteri)           //Hem tüzel hemde gerçek müşteriyi buraya göndermek istiyoruz ama farklı isimdeler..
        {                                           //müşterilerin sınıflarındaki isimlerini TuzelMusteri:Musteri ve GercekMusteri:Musteri yaparsk bunlara siz aynı zamanda Musteri'siniz diyoruz ve ortak paydada buluşturuyoruz.. Bu olayın adı: Miras(Inherati)'dır..
            //if (musteri)                          //Bunları ortak paydada birleştirdiğimiz için müşteride olan özellikler artık gerçekte de tüzelde de vardır.. yani ortakları oraya atarız.. ama bu da yeterli değildir..
            //{
                                                    //Burada ister tüzel ister gerçek müşteriyi tutabilirim..
            //}


        }





    }
}
