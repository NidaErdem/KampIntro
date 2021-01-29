--Northwind'i Execute ettikten sonra Database'i refresh ettik ve altında Northwind seçeneği çıktı.. Ona sağ tıkla new query de ve burası açılıyor..
--Bu query kısmına sorgularımızı yazabiliriz.. İlk öğreneceğimiz komut Select(seç)'tir.. En yoğun kullanılan sorgulardan biridir..
--Select bir veri kaynağındaki detayı çekmek için kullanılan yapıdır..

Select * from Customers 

--Select(Dosyayı seç)- *(normalde selectten sonra ne yazılırsa o ismin kolonları seçilir ama burada * yazıyor.. * ise bütün kolonları seç demek)- from(nereden,hangisiden?)- from Custormers (Customers veri kaynağından bütün (*) kolonları seç.
--5. satırı seçerek sol yukarda içi boş yeşil butona (Execute) basıyoruz.. Böylelikle verinin tüm kolonlarını aşağıdaki T-SQL sekmesinde görebiliriz..


Select ContactName, CompanyName, City from Customers		--burda diyorum ki: Customers'tan şu 3 kolonu seç.. Bu kodu seçip çalıştırırsak(Execute) yazılan 3 kolon görülecektir..
--Biz bunu çalıştırdığımızda bu bellekte fake bir tablo oluşturuyor ve bize onu gösteriyor.. Yani arka planda aynı array gibi bir liste oluşturuyor, buradaki adı tablodur, onu gösteriyor..
--Biz bu 11. satırdaki tabloyu çağırdığımızda ContactName, CompanyName ve City aşağıda tablonun kolon isimleri olarak görünüyor.. (Seç, Execute'le ve gör).. Fakat biz onları şöyle yazarsak:

Select ContactName Adi, CompanyName Sirketadi, City Sehir from Customers
-- ContactName'i Adi, CompanyName'i Sirketadi, City'i ise Sehir olarak bana getir demektir bu.. Bu satırı seçip çalıştırdığımızda kolon isimleri bu şekilde değişir.. Bu isimlendirme olayını alyas(yazılışı yanlış olabilir) denir..
--Bu isimlerin tamamı tablodan geldi.. Tablolara sağ tıkla view data dersen tabloların verilerini, kolon isimlerini felan görebilirsin..

--FİLTRELEME SORGUSU:
Select * from Customers where City = 'London'		--Şehri londra olanların bütün kolonlarını seç.. --where ile şart ekledik.. --Metinler burada tek tırnak ile yazılır..

Select * from Products		--ürünler tablosunu tüm kolonlarıyla getir... --sql case insensitive büyük küçük harf duyarsızdır.. Yani ister Select yaz ister SeLeCT, ister Products yaz ister proDucts..

Select * from Products where CategoryID=1		--1 numaralı kategoriye ait ürünleri getir..
Select * from Products where CategoryID=1 or CategoryID=3	--1 numaralı ya da 3 numaralı kategoriye ait ürünleri getir.. --bu çalıştığında hem 1ler hem 3ler gelecektir.. 
Select * from Products where CategoryID=1 and UnitPrice>=10		--fiyatı 10'a eşit ya da büyük 1 numaralı kategoriye ait ürünleri getir.. --<> olsaydı 10dan farklı olanları getir demektir..
select * from Products order by ProductName		--Bütün ürünleri seç ama ürün ismine göre sırala..
select * from Products order by CategoryID, ProductName		--her kategoride alfebatik, isme göre sırala..
select * from Products order by UnitPrice asc	--Fiyata göre sırala --ascending(artan) şeklinde sırala.. azdan çoğa.. burda azdan çoğa yapacaksak asc yazmasak da olur..
select * from Products order by UnitPrice desc	--descending(düşen, azalan) şeklinde sırala.. çoktan aza, önce en yüksek fiyat..
select * from Products where categoryId=1 order by UnitPrice desc --kategori ıd si 1 olanları filtrele onları fiyata göre azalan olarak sırala..

--bunlar e-ticarette benim yaptığım işlemlerin kod halidir..

select count(*) from Products		--tüm satırları say demek.. count adet demek zaten.. yani Product tablosunda kaç data varın cevabı.. E-ticeret sitesinde mesela 255317 ürün var derse arka planında böyle bir kod vardır..
--count dediğimizde cevap olarak tek satır tek sütunlu bir cevap olmalı.. çünkü toplam sayıyı istiyoruz, 77 ve bitti..
Select count(*) from Products where CategoryID=2		--2 numaralı kategoride olan ürünlerin sayısı
--Bu şekilde bu tek satır ve sütunlu tablonun ismi yoktur.. peki bu cevaba sim koyalım:
Select count(*) Adet from Products where CategoryID=2		--2 numaralı kategoride olan ürünlerin sayısını Adet sütununa yazdım.. çalıştırırsam aralarındaki farkı görebilirim..
--count dedikten sonra hem bunu yapayım hemde şu verileri getir diyemeyiz..

--GROUP BY

--Yönetim dediki hangi kategoride kaç farklı ürünümüz var diye sordu:
--mesela 3 ketegori vvar diyelim.. 1 numaralı kategoriden kaç tane var, 2den kaç tane 3ten kaç tane?
--önce kaç kategori var, ona bakalım;
select categoryID from Products group by CategoryID		--bütün kategorileri tekrar etmeyecek şekilde bana listele(kaç kategori var bulmak için)

--ben bir group by yaptığımda aslında her bir grup için arka planda bir tablo oluşuyor.. işte şimdi bu kodun içinde ek olarak ürünleri sayadabiliriz:
select categoryID, count(*) from Products group by CategoryID		--her bir grup elemanı için categoryID deki grupların her bir elemanı için toplam ürün sayısını veriyor..
--1 numaralı kategoride 12 ürün var mesela

--Yönetim derki hangi kategorilerde az ürün varsa biz o kategorileri besleyelim, ürün ekleyelim..
--Bana ürün sayısı 10dan az olan kategorileri listele derse buraadaki şart koşulu olan where koşulunu kümülatif dataya yapacağız.. Bu yüzden group by larda bu kümülatif dataya yazılan koşul having olarak yazılır..

select categoryID, count(*) from Products group by CategoryID having count(*)<10 --bana 10 taneden az ürün çeşidi olan kategorileri ver.. versin ki yeni ürün ekleyerek eksiklerimi kapatayım..

select categoryID, count(*) from Products where UnitPrice>20 group by CategoryID having count(*)<10
--birim fiyatı 20den fazla olan ürünleri kategori ıd ye göre grupla (filtreleme işlemi), bunlardan da sayısı 10dan az olan ürünleri göster..

--JOİNS..

--müşteriler sitede hangi kategorideki ürüne bakıyorsa oraya kategorinin ıdsini değil, kategorinin ismini yazarız..
--kategorinin ismini getirmek gerektiği için tabloları joinleriz( birleştiririz)
--ben sadece ürünlerden değil, ürünler ile kategorilerin birleşiminden getirmek istiyorum:

select * from Products inner join Categories			--hem ürün hemde kategorilerin bir araya gelmiş şeklidir..
on Products.CategoryID = Categories.CategoryID		--bunları bir araya getircem ama neye göre? bunun için "on" kodunu kullanırız "on" durumunda, şartında demektir..
--Products tablosundaki kategori ıd ile kategori tablosundaki kategori ıd eşitse bunları bir araya getir.
--* tüm kolonlardı ama ben tüm kolonları istemiyorsam aşağıdaki gibi istediğim kolonları çağırırım..:
select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName from Products inner join Categories on Products.CategoryID = Categories.CategoryID
--Products tablosundaki kategori ıd ile kategori tablosundaki kategori ıd eşitse Products tablosundan ProductID'yi, Products tablosunda ProductName'i, Products tablosundan UnitPrice'ı ve Categories tablosundan CategoryName'i bir araya getir..

--C# da biz bu joinlere DTO(Data Transformation Object) deriz.. 

--yukarıdaki koda where, group by her şeyi sırasıyla yazabilirim..
select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName from Products inner join Categories on Products.CategoryID = Categories.CategoryID where Products.UnitPrice>10
--Ürünlerden fiyatı 10 dan büyük olanlar için onu kategorilerle join et ve bana getir.. kısacası bu kod fiyatı 10dan büyük olan ürünleri kategori ismiyle beraber getirecek sorgunun ta kendisidir..

--INNER JOIN..
--Sadece 2 tabloda da eşleşenleri bir araya getirir, eşleşmeyen data varsa onu getirmez..

--Not: tablo isimlerinde boşluk kullanmayız normalde ama northwind'in tablolarına baktığımızda Order Details arada böyle boşluk bırakılarak yazılmıştır..
--Bu sebeple bunu köşeli parantezle yazdık ki onu tablo ismi olarak algılasın.. Birleşik olsaydı köşeli parantezi yazmazdık..

Select * from Products p inner join [Order Details] od	--p ve od onların yeni ismi olduğu için onları kullanarak koda devam edebiliriz.. aşağıdan koda devam ediyom..
on p.ProductID = od.ProductID 
--inner join sadece eşleşen kayıtları getirir.. Yönetm dediki hiç satış yapamadığımız ürünler nelerdir?Bana onu söyle, o ürünlere kampanya yapıp satmaya çalışalım..
--inner ı left yapalım:

Select * from Products p left join [Order Details] od on p.ProductID = od.ProductID 
--left solda olup(Products) sağda olmayanları da(Order Details) getir demektir..
--ürünler tablosunda var ama hiç satışı yoksa onları da getir demektir bu kod..
--çalıştırınca 2155 tane sonuç ile karşılaştım..
--yani ben bütün ürün çeşitlerinden satış yapmışım, Çünkü ürünlerde olup sipariş detayında olmayan ürün yoktur..
--Nasıl mı anladık? Şöyle:
select * from [Order Details]	--burada 2155 tane ürün çeşidinin sipariş detayı vardır..
--satılsada satılmasada ürün çeşitlerinin hepsini getir dediğimde (Satır 91) orada da satılan yada satılmayan ürün çeşitlerinin sayısı 2155 çıktı..
--demekki 2155 tane ürün çeşitinden hiç satamadığım yoktur..

--Yönetim dediki sistemimize kayıt olmuş ama bizden ürün almamış kişileri bana getir, ben onlara kampanya uygulayacağım.. 
select * from Customers c inner join Orders o on c.CustomerID = o.CustomerID	--830 tane müşteri vardır
select * from Customers c left join Orders o on c.CustomerID = o.CustomerID		--832 tane müşteri vardır..
--yani 832 kişiden 830 kişi sipariş vermiş ama 2 kişi, 2 müşteri sipariş vermemiştir..

--şimdi bu üye olup ürün almayanlar için bir kampanya kodu yazalım..

select * from Customers c left join Orders o on c.CustomerID = o.CustomerID where o.CustomerID is null	--solda olup sağda olmayanlar null kodu ile gösterilir..

--Fissa ve Paris isimli arkadaşlar hiç ürün almamış..

--Bide right join vardır ama yukarıdakini right yapamayız çünkü öncelikle left anlamına bakalım bir daha:
--müşteri tablosunda olup sipariş tablosunda olmayan kişiler.. Bu mantıklı bir arayıştır.. Ama right join olsaydı:
--Sipariş tablosunda olup müşteri tablosunda olmayan kişileri sırala demiş olurduk.. Siparişleri veren kişiler müşteri olduğuna göre böyle bir şey yapamayız..
--ancak yerlerini değiştirirsek anlamlı olur:

select * from Orders o left join Customers c on c.CustomerID = o.CustomerID where o.CustomerID is null

--İkiden fazla tabloyu nasıl join ederiz?

Select * from Products p inner join [Order Details] od on p.ProductID = od.ProductID inner join Orders o on o.OrderID = od.OrderID






