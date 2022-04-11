-- tedarikçiler, kategori ve ürünler arasýnda join 

select * from Tedarikciler t inner join Urunler u on t.TedarikciID=u.TedarikciID inner join Kategoriler k on u.KategoriID=k.KategoriID

select * from Musteriler m inner join Satislar s on m.MusteriID=s.MusteriID inner join Personeller p on p.PersonelID =s.PersonelID order by s.NakliyeUcreti desc

--satýþlar ile nakliyeciler tablolarýný birbirine baðla sonra da satýþlar ile personeller iþe ilk baþlayan kiþinin ünvanýný iþe baþlama tarihi, sevk adýný ,þirket adýný ve telefonunu gösteren sorgu nakliye ücreti >500 olanlarý getir
select top 1 Adi,SoyAdi,Unvan, IseBaslamaTarihi,SevkAdi,SirketAdi,Telefon from Satislar s inner join Nakliyeciler n on s.ShipVia=n.NakliyeciID inner join Personeller p on s.PersonelID=p.PersonelID where NakliyeUcreti> 500 order by IseBaslamaTarihi 

 