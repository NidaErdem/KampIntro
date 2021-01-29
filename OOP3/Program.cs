using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Interfaceleri işlicez......!!!!!!!!!!!!
            //Diyelimki bir bankada krediler var ve biz bu kredilerle geri dönüş tutarları belirleyip eğer bu krediyi kullanırsan 2-3-5 yılın sonunda bu kadar para ödersin (işte çiftçi kredisi kullanırsan bu kadar, esnaf kullanırsan bu kadar vs vs)
            //KrediManager sınıfı açıp operasyonları yazalım..
            //şimdi birden fazla kredi çeşidi vardı.. her kredi çeşiti için sınıf açarız ama oop2de de olduğu gibi bu kredi çeşitleri aynı zamanda bir kredidir..
            //Bu sebeple KonutKrediManager adında açtığımız sınıfın ismine gidi ":KrediManager" ı da yazacağız.. Bunu diğer kredi çeşitlerine de yapacağız...
            //hangi çeşit olursa olsun her kredi çeşiti bir kredidir.. oop2de ki gerçek ve tüzel müşterilerin müşteri olması gibi buradaki kredilerin ortak paydası KrediManager dır..
            //Bu yaptığımız işlem zaten Miraslama işlemidir..

            //bütün krediler KrediManagerdaki hespla işini farklı şekillerde ele alır her birinin belli bir faiz oranı vardır ve hepsinin kendine öz dosya masrafları vardır..
            //Kısacası hepside hesapla işini farklı şekilde ele alır.. yani:
            //KrediManager Class halindeyken tek başına benim için bir anlam ifade etmiyor..
            //İşte bu tip alternatif yani imzanın aynı olduğu (void hesapla()) ama içerisinin farklı olduğu durumlarda biz Class KrediManager daki classı, class olarak değilde interface olarak oluştururuz..
            //Oluşturdum.. ve şu şekildeyken; 

            //class KrediManager
            //{
            //     public void Hesapla()
            //     {
            //     }
            //}

            //o şekle getirdim..





            //IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();            //Baştaki IhtiyacKrediManager yerine IKrediManager'da yazabilirdik..
            //ihtiyacKrediManager.Hesapla();

            //TasitKrediManager tasitKrediManager = new TasitKrediManager();                  //Baştaki TasitKrediManager yerine IKrediManager'da yazabilirdik..
            //tasitKrediManager.Hesapla();

            //KonutKrediManager konutKrediManager = new KonutKrediManager();                  //Baştaki KonutKrediManager yerine IKrediManager'da yazabilirdik..
            //konutKrediManager.Hesapla();

            //Bu demek oluyor ki interface lerde o interface i implemente eden classın referans numarasını tutabiliyor.. aşağıdakini yazabilmek için yukarıyı commentledim..



            //şubedeki arkadaşımızın ekranında bulunan 3 kredi aşağıdaki olsun..

            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();  
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();


            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FilebaseLoggerService();
            

            //şimdi başvuru yapıyorum..
            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager, databaseLoggerService );             //buraya hangi kredi türünü yazarsam onun ödeme planı hesaplanır.. //başvuru yapa loglama işlemini koyduğumuz için mecburen buraya da onu koyduk..

            Console.WriteLine("Basvuru yap kısmı bitti, çıktıda ayırt edebilmek için bunu yazdım..");



            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager };       //her listte eğer yapılmamışsa ampüle tıkla "using System.Collections.Generic:" e tıkla

            basvuruManager.KrediOnBilgilendirmesiYap(krediler);


            //bu yaptığımız hareket aslında bir öncekinin aynısı sadece burada liste yolladım ve onları tek tek hesapladım.. (listeye neleri yazmışsam)


            //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            //Diyelimki projemizde loglama yapmak istiyoruz.. loglama nedir? -kim, ne zaman, hangi operasyonu çağırdığıdır yani bir nevi o sistemde olan hareketleri döktüğümüz bir dökümdür..
            //loglamayı farklı yöntemlerle uygulayabiliriz;
            //logları bir dosyada tutabiliriz, veri tabanında tutabiliriz, sms olarak atabiliriz (krediye başvuru olduğunda ona sms gönderilmesi gibi), mail olarak atabiliriz..
            //bu yöntemlerin hepsinin imzası aynı ama dosyaya yazarken dosyaya yazma kodları, veri tabanına yazarken veri tabanına yazma kodları vs yazılır.. ama hepsinde yapılan işlem loglamadır..
            //peki en başta buna nasıl karar vericem?
            //alternatif sistemler varsa (veri tabanına yazma, dosyaya yazma, sms yollama, mail yollama..vs)
            //bazen mesela tek sistem vardır, veri tabanına yazma gibi.. iç müşteri (bankadaki ilgili birimler) tarafından başka bişey istenmez.. böyle durumlarda bile biz ona interface ekleriz..
            //Add-class-interface i seç- ad: ILoggerService (bundan sonra interfacelere servis dicez)




        }
    }
}
