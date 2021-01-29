using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class Musteri
    {
        //public int Id { get; set; }
        //public string MusteriNo { get; set; }                //Eğer bir veri üzerinde matematiksel işlem yapmıyosam, toplamıyosam bölmüyosam, çarpmıyosam, çıkarmıyosam yani ona sayı görevi vermiyosam bunlar metinsel olarak girilirse daha iyi olur..
        //public string Adi { get; set; }                      //Bu yüzden TcNo, MusteriNo, VergiNo stringdir..
        //public string Soyadi { get; set; }                   //Eğerki bir nesnede bir değeri kullanmak zorunda ibi görünmüyosam, yani o nesneye ait değilmiş gibi duruyosa o alan demekki oradada soyutlama hatası yapıyoruz..
        //public string SirketAdi { get; set; }                //Yani bu class da sıraladığımız özellikleri hem tüzel hem de gerçek kişiler için tanımladık ancak gerçek kişilerin şirket adı yoktur..
        //public string TcNo { get; set; }
        //public string VergiNo { get; set; }

        //Yeni 2 sınıf oluşturup ayırdığımız için burayı comment yaptım.. Burası genel olarak müşteri(tüzel+gerçek) classıdır.. Çünkü tüzelide gerçeği de aynı paydada birleştirdim.. 
        //Bu yüzden yukarı kısmı dikkate almadan doğru yazıma şimdi başlayacağız..
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        //şimdi yukarıdaki özellikleri sahiplerine dağıttık.. burada 2 müşteri türünede Id ve MusteriNo'yu yazdık.. Tuzel müşteri ve gerçek musteriyi ortak payda olam musteri classında buluşturduk..
        //Bu sebeple bu iki müşteri türünün ortak özelliklerini buraya yazabilirim.. Bu yüzden o ikisini orada commentledim ve buraya yazdım..

        public int Id { get; set; }
        public string MusteriNo { get; set; }

        //tüzel sınıfında sadece ona ait özellikler, gerçek sınıfında sadece ona ait özellikler yazarken burada ortak özellikler yazmaktadır..


    }
}


   
