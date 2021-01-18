using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
   class Urun
    {
        //prop tab tab
        //O nesneyi tanımlayan birden fazla özellikleri bu şekilde class içinde tutuyoruz.
        //bir datayı diğerlerinden ayırt etmek için kullandığımız eşsiz değerdir.. tc no gibi.. türkiyede birden fazla nida erdem olabilir ama tc kimlik no ile bulunur..
        

        //Property - özellik
        public int Id { get; set; }
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }

        public int StokAdedi { get; set; }

        //buraya yeni bir özellik daha ekledik ve buraya eklediğimiz zaman artık bu da dahil olmuş oldu.. hiçbir sayfam EROR vermez
        //buna encapsulation denir.. kapsülleme demektir.. ayrı ayrı düzensiz yazılan bir yapıyı bir düzen içine, bir kapsül içine alıyorsun..

    }
}
