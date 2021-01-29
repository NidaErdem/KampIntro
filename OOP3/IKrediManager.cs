using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface IKrediManager              //eğer ki birisi  bu interface i kullanırsa orada burada yazılan metotlar kullanılır.. (void Hesapla(); gbi..) //IKrediManager yazdık çünkü bunun interface olduğunu rahatça anlamak için.. classın adınıda öyle değiştim.. başta KrediManager diye açmıştım..
    {
        void Hesapla();             //Krediyle ilgili hesap yapma
        void BiseyYap();            //Krediyle ilg bişey yapma 


        //burası ortak olduğu için şöyle düşünelim: buraya yazılan her metot her kredide olması gereken metotlardır, bunlar zorunludur..
        //burayı bu şekilde interface yapmasaydık class olarak kalsaydı Hesapla(int krediTuru) yazıp altına if kredi türü şuysa şunu yaz, buysa bunu yaz diye diye hepsini yazacaktık ama bir bankada çok fazla kredi türü var, burası bu yüzden çok karışacaktır..
        //bu sebepten ötürü interface bizi o kargaşadan kurtarır...




    }


}
