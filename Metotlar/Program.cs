using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            string[] meyveler = new string[] { };
            //burda bunu yapmam çooook zor

            //bir class tanımlayabilmek için aşağıdakini yapmamız gerekiyor. Bu classın örneğidir.
            //urun1 yerine elma da yazabilirsin ama class oluşturduğunda sağında onun new kısmını da yazman gerekiyor.

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            //bu bir manav uygulaması

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

                Urun[] urunler = new Urun[] { urun1, urun2 };
            //diziyi oluşturdum
            //şimdi e-ticarette olduğumuzu düşün bunu dönebiliyoruz
            //foreach tab tab

            //in urunler dediğinde bebim urunler dizimin her bir elemanını tek tek gez
            //foreach aslında datayı tek tek ekrana basıyor
            //2. yazılan urun aslında takma isimdir.. x de desen olur.. anlamlı olsun diye urun yazdık..
            //c# tip güvenlidir (type safe).. Bu ne demek? = çalışılan veri tipini bilmek istiyor.. bu yüzden 1.yere Urun u yani oluşturduğumuz veri tipini yazdık.. var olarak da kalabilir..

            foreach (Urun urun in urunler)
            {

                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------------");




            }

            Console.WriteLine("----------------Metotlar-------------");

            //classı çağıralım;
            //şu anda intance - class örneği oluşturuyoruz.. yukardaki gibi..

            SepetManager sepetManager = new SepetManager();

            //bu ekleme codunu başka başka yerlere yazabilirim.. 2sayfam var diyelim..
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12, 8);
            //yukardakiler farklı sayfalarda sepete ekleyi (ekle2)yi çağırdım..
            //sonra yönetim dedi ki bunların yanınd ürün stok adedini de yazalım.. sepetmanagerda satır 31e int stok adedi de ekledik..
            //ekledikten sonra burda zortladık çünkü ekle2nin yapacağı işi değiştirdik ama burda aynı kaldı, bu yüzden ERORRRRR..
            //şimdi bütün sayfaları gidip tek tek değiştirmem lazım, (değiştirdik ve stok adedini yazdık diyelim)




            //bunu yazdığımda sepetmanagerdaki satır 31 e gidiyor ve orda içerisinde ne yazıyosa çalışıyor..
        }
    }
}
