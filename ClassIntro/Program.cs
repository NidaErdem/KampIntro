using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Nida";
            int yas = 26;

            //aşağıdaki kurs değişkenini ekleyebilmek için daha aşağıda Kurs adında bir sınıf açık önce.. 
            //C# benim kendi oluşturduğum değişkeni böylelikle tanıdı.. kendi veri tipim..
            //bir kurs değişkeni tanımlamak için onu şöyle tanımlamak gerekiyor
            //tanımladığım classın değişkenlerini oluşturmak için ve değerlerini atamak için bunu yapmam gerekiyor

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem Barış";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Phyton";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 80;


            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "Murat Kurtboğan";
            kurs4.IzlenmeOrani = 100;

            //bunlar gerçekte bir veri kaynağından gelecek..
            //veri tabanından gelecek, bunları da öğrencez..

            //Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen);

            //bu 4 kursu bir dizide tanımlarsam veri tipim string değil de Kurs olacak.. 
            //Yani içinde Class daki Kurs nesnesini barındıran bir array (dizi) tanımladım..
            //kurs yazarsam içinde kurs tutarım, string yazarsam metin tutarım, int ve flood sayı tutar vs vs..

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3, kurs4 };

            //döngü yapalım

            foreach (var kurs in kurslar)
            {
                //o anki kursun adını ve o anki kursun eğitmenini yazdırmak istiyorum..
                //bu yüzden kurs1 değil de kurs yaptık..
                //bu bir döngü olduğu için bütün kursları dolanacak

                Console.WriteLine(kurs.KursAdi + " " + kurs.Egitmen);
            }

            


        }
    }

    //class tab tab
    //prop tab tab
    // 1 tane kurs objesi oluşturuyorum.. bu yüzden kursun değişkenlerini sınıf halinde yazıyorum
    //bir class tanımlamak için bunu yapmam gerekiyor

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}
