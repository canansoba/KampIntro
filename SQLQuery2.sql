--Select
Select ContactName Adi,CompanyName SirkedtAdi,City Sehir from Customers -- kolon isimlerini değiştirdi

Select * from Customers where City = 'London' -- şehri londra olanları getir 

Select * from Products -- tüm ürünler gelir

Select * from Products where CategoryID=1 or CategoryID=3 --kategoriID 1 yada 3 olanları getir

Select * from Products where CategoryID=1 and UnitPrice>10

select * from Products order by ProductName --order by sırala demek bütün ürünleri ürün ismine göre sıralar

select * from Products order by CategoryID,ProductName

select * from Products order by UnitPrice asc -- fiyata göre sırala asc artan

select * from Products order by UnitPrice desc --fiyatı azalana göre sırala

select * from Products where CategoryID=1 order by UnitPrice desc

select count(*) from Products -- Product tablosunda tüm satırları say onun sayısını ver
								-- count tek kullanılır yanına ekstra bir bilgi getir denilmez

select count(*) Adet from Products where CategoryID=2 -- ama bu şekilde kullanılır

select CategoryID from Products group by CategoryID -- bütün kategorileri listele

select CategoryID, count(*) from Products group by CategoryID -- hangi kategoride kaç farklı ürün var ?

--ürün sayısı 10'dan az olan kategorileri listele

select CategoryID, count(*) from Products group by CategoryID having count(*)<10

--birim fiyatı 20 den fazla olan ve sayısı ondan az olan ürünleri kategori Id'ye göre grupla

select CategoryID, count(*) from Products where UnitPrice>20 group by CategoryID having count(*)<10

--iki tabloyu kategori Idler eşit olduğunda birleştir
select * from Products inner join Categories on Products.CategoryID = Categories.CategoryID

--tüm kolanlar yerine istediğim kolanları göster ve tabloları birleştir

select Products.ProductID,Products.ProductName,Products.UnitPrice, Categories.CategoryName 
from Products inner join Categories on Products.CategoryID = Categories.CategoryID

--DTO Data Transformatn Object C#'da 

--ürünlerden fiyatı 10'dan büyük olanlar için categorilerle joinle getir

select Products.ProductID,Products.ProductName,Products.UnitPrice, Categories.CategoryName 
from Products inner join Categories on Products.CategoryID = Categories.CategoryID 
where Products.UnitPrice>10

--iki tabloyu joinleyeceğin zaman ortak tabloyu bul

--od order details p product

select * from Products p inner join [Order Details] od on p.ProductID = od.ProductID

--product tablosunda olup order details de olmayanlarıda getir

select * from Products p left join [Order Details] od on p.ProductID = od.ProductID

--hem inner join olanalrı hemde müşterilerde olmayanlarıda getir
select * from Customers c left join Orders o on c.CustomerID = o.CustomerID

--sistemimize kayıt olmuş ama ürün almamış kişileri getir
select * from Customers c left join Orders o on c.CustomerID = o.CustomerID 
where o.CustomerID is null

select * from Customers c right join Orders o on c.CustomerID = o.CustomerID 
where o.CustomerID is null

--ikiden fazla tabloyu joinlemek istersen
select * from Products p inner join [Order Details] od on p.ProductID = od.ProductID
inner join  Orders o on o.OrderID = od.OrderID