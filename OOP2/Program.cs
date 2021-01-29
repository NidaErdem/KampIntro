using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {

            // Mirasları(Inheratis)İşliyoruz.....!!!!!!!!!!!

            //Engin Demiroğ
            //Musteri musteri1 = new Musteri();
            //musteri1.Adi = "Engin";
            //musteri1.Soyadi = "Demiroğ";
            //musteri1.Id = 1;
            //musteri1.TcNo = "22222222";
            //musteri1.MusteriNo = "12345";
            //musteri1.SirketAdi = "?";

            //şirket adı bu müşteriyle ilgi değil bu yazım şekli de hatalıdır.. Sebebi:
            //Zamanla şirket adı olan bireysel müşteriler, Tc nosu olan tüzel müşteriler, Adı soyadı olan tüzel kişilerle karşılaşırız çünkü yanlış girilmiştir..
            //2 nesnem var (Gerçek-Tüzel Müşteriler), bunlar sırf birbirine benziyor, sırf müşteri diye birbiri yerine kullanılamaz..
            //soLid.. 

            //Peki bunu nasıl yapmalıydık? Add- 2 class ekle.. Gercek müşteri için ayrı tüzel müşteri için ayrı sınıf oluştur..
            //2 tane özellik classı oluşturduk sonrada operasyon classı oluşturcaz ve müşteri işlemlerini orda yapcaz (MusteriManager)

            //şimdi müşteri sınıflarını (tüzel-gerçek ve ortak özelliği barındıran müşteri sınıflarını) oluşturduğumuza göre müşterilerin doğru kayıtlarını yazabilirim....


            //Engin Demiroğ
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "12345678901";


            //Kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";





            Musteri musteri3 = new GercekMusteri();             //Musteri hem gerçeği hem de tüzeli tutabiliyor.. eğer bir yerde new görürsek bellekteki referans nosudur..
            Musteri musteri4 = new TuzelMusteri();              //musteri classı hem gerçek kişinin hem de tuzel kisinin referans nosunu tutabiliyor..

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);          //musteri 3 ve 4 üde ekleyebilirim..

            


        }
    }
}
