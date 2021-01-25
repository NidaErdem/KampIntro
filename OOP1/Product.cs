using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        public int Id { get; set; }     //bir nesneyi diğerinden ayırt edebilmek kullandığımız şeydir ıd
        public int CategoryId { get; set; }         //ürünün hangi kategoride olduğunu yazıyoruz..Id ana anahtar, bu ise referans anahtarı gibi diyebiliriz.
        public string ProductName { get; set; }     //ürün ismi
        public double UnitPrice { get; set; }       //ürünün birim fiyatı
        public int UnitsInStock { get; set; }       //stok adedi

    }
}


//bu tip classlarda aynen bu şekilde sadece özellik olur..