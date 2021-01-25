using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
               //Add- class- isim= MyList

            MyList<string> isimler = new MyList<string>();          //isimler artık MyList türündedir.. //bunu bu şekilde kullanabilirim ama <string> yazan yerdeki liste gibi kullanmak istiyorum.. Bu yüzden MyList e gidelim ve o şekle getirelim..
                                                                    //MyList isimler = new MyList(); ilk hali bu şekildeydi.. <> şekilli yazma sebebimiz: bu generic bir class ve içerisinde olan metotlar tip bağımlı çalışıyor (verilen tipe göre hareket ediyor, tipe bağlı) bu yüzden çalışacağımız veri tipini belirttik..

            //yukarıdaki string türünden bir listedir.. int yazsa int türünden, product yazsan product türünde vs vs..

            isimler.Add("Engin");           
        }
    }
}
