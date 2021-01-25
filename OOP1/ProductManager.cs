using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)       //Ekleme operasyonu.. Mantıken bakalım: Biz bir ürün ekleyeceksek bu ekleme operasyonuna neyi ekleyeceğimizi söylememiz lazım.. Programcs ye gidelim.. 
        {
            //Geldim, Add içini yazıyorum... Product türünde bir veri ekliyoruz.. Eğer orada string yazsaydı programcs de satır 30da add parantesi içine string türünde veri girmemiz gerekiyordu; "Nida"
            //yani buradaki addin içi aslında metodumuzun nasıl çağrılacağını anlattığı yerdir.. 
            //product türünde verileri zaten programcs nin içinde tanımlamıştım; product1 ve product2.. //buraya product türünde bir veri ekle dediğimiz için programcs satır30da rahatça o türdeki veriyi ekledik.. 
            //string olsaydı o türde tanımlayıp onları ekleyecektim..
            //yani sonuç olarak ben verilerimi product tipinde oluşturmuştum bu yüzden burası product tipindeki verileri ekle diyor.. programcs kısmındaysa hangi verinin gönderileceğini yazıyoruz ve veri buraya gönderiliyor..
            //sen bana product türünde işey gönderceksin ben onu product(2.yazan) isminde s,stemde tutuyo olucam.. (bu kısmı ufak örnekle defterde de anlattım.. burdaki gidişatı özetledim.. sonuçların nedenlerini ait oldukları yere yazdım..)

            // product.ProductName = "Kamera";  etkinsizleştirdik.. şimdi bu örneği bırakalım ve devam edelim..

            Console.WriteLine(product.ProductName + " eklendi.");
        }

        public void Update(Product product)         //güncelleme   
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }



































        //--------------------------------------------------------------------------KONU DIŞI AÇIKLAMALAR-------------------------------------------------------------------------
        //void nedir? bu anahtar kelime ne işe yarıyor?
        //void diye belirtilen metotları şöyle düşünebiliriz; emir kipinde git ekle, git sil vs.. emir kipiyle onu çağırıyoruz ve o işlemini yapıp  bitiriyor..
        //benim bu add ya da update sonucunda o işlem sonucunun ne olduğu ile ilg ekstra bir birlgeye ihtiyaç yoksa o voiddir..
        //ama şöyle olsaydı:
 //       public int Topla(int sayi1, int sayi2)          //(------1-----)
 //       {
 //         return sayi1 + sayi2;
 //       }

  //      public void Topla2(int sayi1, int sayi2)      //(------2------)
 //       {
 //           Console.WriteLine(sayi1 + sayi2);
 //       }

        //1 ve 2 numaralı metotun farkını anlatalım:
        //2 numarada sayi1 ve sayi2 yi toplayıp ekrana yazdırıyo.. şimdi metotu oluşturduk diye programa gidip bu metotu çalıştır diyeceğiz..
        //oraya şunları yazdım:

        //productManager.Topla2(3, 6);    // (------2------) //yukarıda zaten productManager ı ProductManagerlaştırmıştık zaten.. Bu şu demektir; ProductManager daki Topla2 yi çalıştır.. Sayılarım zaten 3 ve 6.. 
        //bu gider PM sayfasına ve sayı değerlerini yerine koyduktan sonra yazar.. Amacımda buydu, ulaştım..



        //return e neden ihtiyacım var?
        //bankacılık uygulamasında krediyi gider hesaplarız ortaya çıkan sonucu başka bi yerde bi daha kullanırız..
        //yani işlem sonucunda ortaya çıkan formül sonucunu ben başka bir şeyde daha kullanmak istiyorum.. o yüzden biz int i kullanıyoruz..
        //bu şu demek: mu metotu çağırırsan ben sana int tipinde bişey veririm.. başka bişey olmaz..
        //program.cs ye şunları yazdım: 

        //int toplamaSonucu = productManager.Topla(3, 6);   //(------1------)  //şimdi biz buradaki toplama değerini yani int toplamSonucu return etme sebebimiz bu değeri başka yerlerde de kullanmak istememdi

        //mesela 2 ile çarpalım dersek:
        //Console.WriteLine(toplamaSonucu*2);      //Gitti hesapladı önce sonra geri geldi ekrana yazdırmak istiyorum, üzerinde çalışmak istiyorum.. onu baaşka şekilde veya yerde kullanmak istiyorum..
        //Bunun için returnları kullanıyoruz..



    }

}
