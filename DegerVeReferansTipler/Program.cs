using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //1. örnek
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 kaçtır?
            //sayı1 10, sayı2 30.. sayı1i sayı2 ye eşitledik yani sayı1 burda 30 oldu.. sayi2 65 ve sayi1 30 da kalıyor.. CEVAP 30

            //2. örnek
            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] ?? sayılar 1in 0. elemanını yazdırsaydım sonuç? CEVAP 999



            //sayısal veri tipleri (int, decimal, floot, double, bool(true/false-- (arka planda 0 ve 1 i tutar)) =değer tip
            //ama bir array, bir class bir interface karşımıza referans tip olarak çıkıyor..
            //1 ve 2. örneğin sonuçlarının değişik olmasının sebebi bu değer ve referanstır..
            //bellekte "stack" ve "heap" diye 2 alan var..
            //Bir değişken tanımladığımda örnek1 deki gibi bir int sayi dediğimde değer tip oluyor ve stackde gerçekleşiyor..

            //1. örnek çözümü:
            //değer tipleri nasıl okuyoruz? sayı1in değeri 10, sayı2nin değeri 30 dur..
            //sayi1=sayi2 kısmında şöyle okunur.. sayi1in değeri eşittir sayi2nin değeri.. yani 10 sayısının bir anlamı kalmaz ve sayi1 in değeri 30 olur.. sonrasında sayi2nin değeri 65 olmuştur ve sayi2de 30un anlamı kalmaz.. 
            //..ancak sayi1 30 olarak kalır çünkü kodlar yukardan aşağı okunur ve sayi2den sonra sayi1 ve sayi2 arasında olan herhangi vir bağ yazılmamıştır..


            //2. örnek çözümü
            //int [] sayilar1 yazdığımda, bir tanımlama yaptığımda aslında stack de sayilar1 diye bir değişken tanımladım
            //new dediğim anda sayilar1 için heap de yeni bir alan oluştur ve değerleri oraya yaz demiş oluruz..
            //     Stack            Heap
            //(101)sayilar1    (101)[10,20,30]
            // (102)sayilar2   (102)[100,200,300]
            //bunların heapde ve stackde eşleşmesi için bir adres değeri olur.. (101 ve 102) referans numaralarıdır..

            //demekki new demek heap de yeni bir yer oluştur demektir..
            //22. satır aslında şöyle okunmalı: sayılar1 in referans numarası sayılar2 nin referans numarasına eşittir.. yani sayılar2 nin referans numarası=102dir bu yüzden sayılar1inde refarans numarası =102 oldu
            // 101-101 102-102 şekilde değerler eşleşiyordu.. şimdi sayılar 1in referans numarası 102 olduğuna göre onun heap değerleri de 100,200 ve 300dür..
            //sonra diyor ki sayilar2'nin 0. elamanı yani 100 olan yer 999 demiş..
            //sayilar1in referans nosu ile sayilar2nin referans nosu aynı olduğundan 102. referans nolu 0. eleman 999 olarak değişmişse sayilar1in 0. elemanı da 999'dur..

            //101 referans nolu heap satırını tutan hiçbir şey yok.. ve çöp toplayıcısı onu bellekten atar.. bıy bıy..

        }
    }
}
