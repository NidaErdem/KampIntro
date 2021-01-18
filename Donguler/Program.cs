using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";
            string kurs5 = "C++";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            Console.WriteLine(kurs5);

            //array - dizi
            //normalde bu kursları da tek tek yazmıyoruz, sistem üstünden kursları çağırıyoruz ama şimdilik öğrenmek için böyle yazdık


            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya Başlangıç İçin Temel Kurs", "Java", "Python", "C++" };

            //her biri için 1 kere dön

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            //sadece i yazsaydık 0-1-2-3-4 çıkardı. bu şekilde isimleri yazıyor.
            //kurslar.length = aslında kaç eleman varsa odur. lenght zaten eleman sayısıdır. dizideki kursların eleman sayısı

            Console.WriteLine("For bitti");
            //bu döngünün bittiğini anlamak içindi


            //başka bir döngü yöntemi 
            //foreach dizi temelli yapıları tek tek dönmeye yarar
            //kursları dolaş ve oradaki kurs ismi göstermelik xyz bile yazsan çalışır ama malum, maksat belli olsun

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
