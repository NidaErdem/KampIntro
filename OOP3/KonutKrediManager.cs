using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class KonutKrediManager : IKrediManager         //burası önceden :KrediManager dı ama interface yaptığımız için onun adını IKrediManger yapmıştık burada da öyle düzelttik ve ampüle tıklayarak Implement Interface'e tıkladık..
    {                                               //bunu diğer kredi türlerine de yaptık.. bu şekilde zaten zorunlu metotlar eklenmiş oldu..
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Konut kredisi ödeme planı hesaplandı.");
        }
    }
}
