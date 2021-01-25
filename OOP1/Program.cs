using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            //managerdan geldim

            Product product1 = new Product();               //101
            product1.Id = 1;  //1 numaralı ürün..
            product1.CategoryId = 2;        //2 numara mobilya kategorisi olsun..
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;


            //manager classını yukardaki gibi yapabilirz.. Veyahut aşağıdaki gibi de yapabiliriz.. 2. ürünü farklı yolla yazalım (İstediğini kullan)

            Product product2 = new Product { Id = 2, CategoryId = 5, UnitsInStock = 5, ProductName = "Kalem", UnitPrice = 35 };

            //elimizdeki bir ürünü eklemeyi simüle etmek istiyoruz.. Bunun için yazılmış bir classım var zaten: ProductManager..ProductManagerın Add metotunu kullanarak bu ekleme işlemini simüle etmek istiyoruz..
            //nasıl ki kullanıcıdan bilgileri alarak böyle bir class oluştruyosam aynı şekilde PrpducktManagerı kullanarak benim product1 i yada 2yi alıp kullanıcıya göndermem gerekiyor..

            //PascalCase    //camelCase
            ProductManager productManager = new ProductManager();       //ProductManager türünde productManager adında yeni bir ProductManager (string isim = "Nida" burada string türünde isim tanımladık ve o Nida.. Diğeri de bu mantık işte..)
                                                                             // yeni bir referans numarası almış productManger..

            productManager.Add(product1);                                       //burada parametreleri ekliyoruz..Add ekle demek ya unutma, toparlan.. uyuyosun şu anda bunu okurken, biliyorum.. ProductManagera geçtim, Add kısmını ekleyeeğim..
            Console.WriteLine(product1.ProductName);







































            //---------------------------------------------------------KONU DIŞI ÖRNEKLER------------------------------------------------------------------------------------------------------------------
            //şimdi gönderdiğimiz yerde kamera yazsın diyodu product1 in ProductName i nedir? (defterdeki örneğede bak)
            //CEVAP: KAMERA..
            //NEDEN? 
            //Geçen dersihatırla sayısal olan (int, double, bool..vs) veri tipleri için değer tip demiştik..
            //Ama dizi, class,abstract class, interface... vs referans tiptir..
            //Değer tiplerde atamalar tamamen değeri üzerinden olur ve bütün bağlantı kopar.. yani ben int sayi = 100; dediğimde BiseyYap fonksiyonuna int sayi yi yolladığımda aslında biz oraya sayının sadece değerini gönderiyoruz.. sayiyla o an bütün bağlantımız kopuyor..
            //Bu yüzden ben metot kısmında BiseyYap fonksiyonunda 100 değerini (int sayi) gönderdiğimde buradaki int sayi ya eşitleniyor.. yani sayi = 100 dedikten sonra sayi yazan her yere 100 yazabilirsin.. onun eki artık kalkıyor, açıklaması kalkıyor..
            //Ben orada sayi = 99 yaptım yani ordaki bağımsız olan ama değeri 100 olan sayiyi 99 yaptım.. bunun int sayi = 100; ile hiçbir alakası olmadığı için yazdırdığımda sonuç yine 100 çıkacaktır..

            //ama referans tiplerde atamalar referansın numarasıyla yani bellekteki adresiyle yapılır..
            //11. satırda new ile oluşturduğum değişkenin bellekteki adresi diyelim ki 101.. 101 numaralı bellek adresi üzerinden gidiyor yani bellekteki yerine referans vererek gidiyor.. bu yüzden ben oraya (satır 30) product ı yolladığımda 101 numaralı bellek adresini yolluyorum.. bellekteki fizziksel bir locasyonu yolluyorum..
            //Bu yüzden burda benim manger kısmında satır 9da yolladığım şey product 101 numaralı bellek adresi oluyor.. Dolayısıyla 18. satırı okursak; 101 numaralı bellekteki yerde bulunan productın name ini Kamera yap diyor.. 
            //bunlarda her şey referans numarası üzerinden gidiyor.. Şu anda 101 numaralı bellekteki product ın adı kamera oldu.. o yüzden ben program.cs de ben 31. satırdaki gibi 101. bellekteki veriyi okuduğumda Kamera yazacak..
            //Bu sebeple cevap Kamera


            //////!!!!!!!!!!!!!!!!!!!!!! REFERANS VE DEĞER TİP ÖRNEKLERİ ÇOK ÖNEMLİ!!!!!!!!!!!!!!!!!////////////////// 
            //(sayısal örnek defterde..)

            //---------------------------------------------------------KONU DIŞI AÇIKLAMALAR DEVAM---------------------------------------------------------------------------------------------------------------

       //     productManager.Topla2(3, 6);    // (------2------) //yukarıda zaten productManager ı ProductManagerlaştırmıştık zaten.. (Ssatır 27) Bu şu demektir; ProductManager daki Topla2 yi çalıştır.. Sayılarım zaten 3 ve 6.. 
                                                                //bu gider PM sayfasına ve sayı değerlerini yerine koyduktan sonra yazar.. Amacımda buydu, ulaştım..



       //     int toplamaSonucu = productManager.Topla(3, 6);   //(------1------)  //şimdi biz buradaki toplama değerini yani int toplamSonucu return etme sebebimiz bu değeri başka yerlerde de kullanmak istememdi

            //mesela 2 ile çarpalım dersek:
      //      Console.WriteLine(toplamaSonucu*2);      //Gitti hesapladı önce sonra geri geldi ekrana yazdırmak istiyorum, üzerinde çalışmak istiyorum.. onu baaşka şekilde veya yerde kullanmak istiyorum..
                                                     //Bunun için returnları kullanıyoruz..

        }
    }
}
