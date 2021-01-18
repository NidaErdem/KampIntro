using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //bir alışveriş sitesindeki sepete ekleyi düşünelim.. sepet ile ilg işlemler, müşteri ile ilg işlemler, müşteri ile ilg işlemler vs vs gibi gruplandırıyoruz
        //şimdi metot yazacağız.. phyton da bunu def ile yaptık
        //isimlendirme kuralı -- naming convention
        //java ve c# da normal parantez görürsek bilelim ki orada metot var

        //syntax -yazım şekilleridir.. metotların syntax ı aşağıdaki gibidir

        public void Ekle(Urun urun)
        {
            //sadece ekle yetmez.. neyi ekleyeceğim? onu da yazmalıyım.. buna parametre diyoruz (Urun urun) 1. urun veri tipi 2. urun onu birazdan aşağıda kullanırken isimlendirme.. yani ben onu o isimle kullanıcam..
            //bu metodun yapacağı kod bu süslü pantezler içine yazılır..
            
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urun.Adi);
            //bana gönderilen urunun adını da yazdırıyoruz + urun.Adi ile..

            //burası 1 satırda olabilir 100 satırda olabilir.. ben bu ekleyi çağırınca buradaki bütün satırlar çağırılır..
            //diyelim ki değişiklik geldi bu koda.. "Sepete ekleni" yerine "Tebrikler. Sepete eklendi!" yazsın
            //buradan değiştirirsem (ki değiştim ben) her yerde, her sayfada değişir..

        }
         //bir classın içinde birden fazla metot olabilir.. ekle2 gibi..

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            //yukardaki satır diyor ki ben eklicem ürünü ama bana ürünün adı, açıklaması ve fiyatını ver ki ben gidip veri kaynağına bu 3ünü birden ekleyeyim
          
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urunAdi);



        }



    }
}
