using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>          //burdaki parantez içine istediğimi yazarım sadece string değil, int,bool,bir class (product classı, müşteri classı, kredi classı, sepet classı..vs) heeerrr şeyi koyabilirim.. 
    {
                            //Generic Class demek çalışacağımız özel bir tip olacağını belirtmektir.. Bu yüzden oradaki "T" Type'ın (Tip) T si..Ama aslında ne yazarsam da olur.. İstersem A yazarım...
                            //Bu şu demek: ben mylistimde T ile çalışcam.Peki bu ne anlama gelir?:Normal List de mesela ekleme yaparken Add içindeki eleman stringdi ama 10 yazarsak kabul etmez.. çünkü liste türü string olarak tanımlanmış, string dışına çıkamaz..

        //Add metodu ekleyelim..
        //public void Add(T item)                  //ben sana T olarak ne verirsem istediğim elemanın türü de odur.. Sonradan belirleyebiliriz yani.. //item eleman demek, elemanda yazabilirsin..
        //{
            

        //}

        //şimdi programda olan List arkasında bir arrayi yönetiyor, bir array kullanıyor.. Bu yüzden bende bu listemin arkasında bir array tutup onu yöneteceğim.. 
        //bu array i, bu listeyi MyList parantezleri içine yazıyoruz ki başka bir metotta da kullanabilelim.. Add parantezleri içine yazsaydık sadece orda kullancaktık ve diğer metotlar içinde tek tek tanımlayacaktık..

       /* T[] items;*/         //items yazarak o listeyi metotlar içinde kullanabilirim.. T tipinde items dır..

        //şimdi benim listede eleman sayısı işini halletmem lazım.. programın otomatik kodu olan listte şöyle bir kod yazmıştık:
        //List<string> isimler2 = new List<string>(); ve içine elemanları vs yazmıştık ama diyelimki bu şekilde ben eleman sayısına bakıcam eleman sayısı belirtilmemesine rağmen burada
        //Console.WriteLine(liste.Count); yazdığımda eleman sayısı olarak 0 yazacak.. bizdede yazabilmesi için yukarıdaki arrayi newlwmwliyiz..
        //public MyList()             //ctop- tab - tab yaptık. buna constructor denir.. bu aslında bir metottur, classın ismiyle aynıdır, void vs yoktur, direk çalışacak.. ben büyük classımı ( class MyList<T>) newlersem bu otomatik çalışır..
        //{
        //    items = new T[0];           //burada newledim.. başladığında 0 elemanlı olarak newlemek istiyorum.. Bu yüzden bu blogum var.. Bir class yenilendiğinde çalışan bloga rconstructo denir..
        //}


        //ŞİMDİ YUKARIDAKİLERİ SIRAYLA TEKRAR YAZACAĞIM, ORASI BU YÜZDEN FULL COMMENTLİ..
        //BENİM ELİMDE 0 ELEMANLI BİR DİZİ VAR VE BEN ARTIK ADD İLE DİZİYE ELEMAN EKLEYEBİLİRİM...

        T[] items;

        public MyList()                                         //constructo olduğunu classla aynı isimde olmasıyla anlıyoruz..
        {
            items = new T[0];
        }


        public void Add(T item)                         //Dizimin eleman sayısı 0 olduğu için öncelikle dizimin eleman sayısını bir arttırmalıyım yoksa ekleme yapamam..
        {
            T[] tempArray = items;                      //aşağıda dediğim gibi referans noyu buraya tutrurmak istiyorduk.. Bu aslında geçici dizinin referansı itemsın referansıdır demek bu.. 
                                                        //Artık elemanlar kaybolmayacak.. önceki elemanlar artık buraya gelecek.. şimdi gönül rahatlığıyla newleyip 1 arttırabilirim..

            items = new T[items.Length + 1];                //items.Length dizinin eleman sayısıdır.. eleman sayısını 1 arttıracağım için +1 yazdım.. 
                                                            //şimdi bir eleman ekledik "Engin".. sonra bi tane daha eklemek için bunu yeniden yazdığımızda newlediğimiz için geçen seferki gibi önceki elemanlar (engin) siliniyor..
                                                            //aslında silinen referans numarasıydı, hatırla.. Bu yüzden geçici bir dizi oluşturup o referası oraya tutturmam lazım.. Bunun başına da geçici diziyi (tempArray) yazdım..

            //örneğin 5 eleman olsaydı ve 6. elemanı ekleyecek olsaydım tempArray in eleman sayısı 5, ama items ın 6dır..
            //şimdi geçici listeye emaneten verdiğimiz değerleri geri alıp yeni listeye koyacağız..

            for (int i = 0; i < tempArray.Length; i++)          //0 dan tempArrayin eleman sayısına kadar istiyorum.. tempArray de diyelim ki 5 eleman var: 0dan 4e kadar gibi..
            {
                items[i] = tempArray[i];
            }

            //artık items eski değerlerine kavuştu.. 

            items[items.Length - 1] = item;         //itemsın son elemanı (items sayısının bir azı çünkü mesela 6 elemanlı ama biz 0-1-2-3-4-5 diye sayıyoruz..) = yukardan gelen items
                                                    //aslında eklenmek istenen eleman şu an eklendi..



        }




    }
}
