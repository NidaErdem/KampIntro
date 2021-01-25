using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //bizim dizilerimiz vardı string aray vardı, string veri türünde verileri topluyoduk..

            string[] isimler = new string[] {"Engin","Nida","Halil","Kerem" };   //-------1-----   //bu diziden anladığımız kadarıyla isimler 4tane elemandan oluşuyor..
            //yani biz isimlerin sıfırıncı elemanını yazdırabiliriz..
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);

            //ben bu diziye yeni bir eleman eklemek istiyorum..
            //   isimler[4] = "İlker";
            //   Console.WriteLine(isimler[4]);      //error verdi.. --System.IndexOutOfRangeException: 'Index was outside the bounds of the array.'--
            //sen bu dizinn 5. elemanını okumaya, set etmeye çalışıyorsun ancak senin dizinde öyle bir yer yok.. bu yüzden bunları //lıyorum

            //şöyle yazabilirdik;

            isimler = new string[5];        //------2------        //eleman sayısı 5 olan bir dizi.. teknik olarak 5. elemanı eklemeye çalışıyoruz..
            isimler[4] = "İlker";
            Console.WriteLine(isimler[4]);

            //diyelimki bunu yaptıktan sonra ben 0. elemanı da yazdırmak istiyorum;
            Console.WriteLine(isimler[0]);      //çalıştırınca gördüğümüz gibi bunu yazdırmadı.. (engin,nida,halil,kerem,ilker,engin yazmalıydı.. son istediğimi yazmadı).. Peki neden?
                                                //new dediğimiz anda bellekte yeni bir referans adresi oluşur.. yani 2 numaralı dizi 1 numaranın devamı değil bambaşka bir dizidir.. 
                                                //bu dizininde 0. elemanını tanımlamadığımız için boşluk vardır..
            Console.WriteLine(isimler[4]);      //tekrar bunu yazdığında aradaki boşluğun sebebini yukarıda anlamış oldun..
                                                //1 numaralı dizi bambaşka bir adresti ve ben gittim onun adresini değiştim...

            //yani dizilerdeki problem dizileri genişletemiyoruz.. yeni bir eleman ekleyemiyoruz.. bunu yapmanın tek yolu 2 numaralı diziyi yazmak ama o zamanda 1 numaralı diziyi kaybediyoruz.. birbirlerine dahil olmuyorlar..
            //satır 11 de dizinin elemanları gerçek hayatta bir veri kaynağından geliyor, içine girip yazı yazamıyosun..

            //bu yüzden koleksiyonlar C# hayatına girdi...

           // List<string> isimler2 = new List<string>();                            //List yazar yazmaz solda çıkan ampule tıklıyoruz ve "using System.Collections.Generic;" i tıklayarak ekliyoruz yukarıya (satır 2).. sonra koda devam et..
           //isimler2.Add("Engin");                                                //çalışma türüm string belli zaten.. bu listeye eleman eklemek için Add fonksiyonunu kullanabilirim..

            //Şöyle de yazabilirim; (üstteki seçeneği comment yapmadan çıktı vermedi..)

            List<string> isimler2 = new List<string> { "Engin", "Nida", "Halil", "Kerem" };     //burda da aynen 14-15-16-17. satırdaki gibi değerleri okuyabilirim
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            //yeni eleman ekleyelim;
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);                                                 //diğeri gibi 5. elemanı ekledik ve onunla beraber eski elemanlardan birini yazdırmak istiyoruz..
            Console.WriteLine(isimler2[0]);

            //koleksiyonların arrayler gibi değerleri kaybetmesini engelleyecek bir alt yapı vardır..

            //eğer C#da List diye bir şey olmasaydı biz bunu nasıl yazardık?
            //List aslında bir sınıf, zaten sınıfların yeşil renkte olduklarını görebiliyoruz..
            //böyle bir şeyi nasıl yazdığımı buraya yeni proje- console app .net core (GenericsIntro) ekleyerek gösterelim.. (yani bu list gibi bişeyi ben nasıl yazardım?)





        } 
    }
}
