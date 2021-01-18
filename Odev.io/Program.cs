using System;

namespace Odev.io
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Name = "Kitap";
            product1.Price = 14.90;
            product1.Explanation = "Küçük Prens";


            Product product2 = new Product();
            product2.Name = "Cep Telefonu";
            product2.Price = 14.349;
            product2.Explanation = "Apple iPhone 11 Pro Akıllı Telefon, 512 GB, Yeşil, Kulaklık ve Adaptör Dahil";

            Product product3 = new Product();
            product3.Name = "Termos";
            product3.Price = 458.54;
            product3.Explanation = "Stanley Klasik Vakumlu Termos, 1.9 lt";

            Product[] products = new Product [] { product1, product2, product3 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.Name + " " + product.Price + "TL");
            }

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].Name + " " + products[i].Price + "TL");
            
            }
        }

        class Product
        {
            public string Name { get; set; }
            public double Price { get; set; }
            public string Explanation { get; set; }
        }

    }
}
