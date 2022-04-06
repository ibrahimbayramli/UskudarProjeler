/*
Order by
order by ile sýralama yapýlýr. 
*/

select * from Musteriler order by MusteriAdi Desc --Z'den A'ya doðru sýralama yapar.

select * from Musteriler order by MusteriAdi asc --A'dan Z'ye doðru sýralama yapar.

select MusteriAdi,MusteriUnvani from Musteriler order by MusteriUnvani asc

-- satýþlar tablosundan nakliye ücreti 100'ün altýnda olanlarý satýþ tarihlerini desc olarak sýralayýnýz.
select * from Satislar where NakliyeUcreti<100 order by SatisTarihi desc

--Ürünler tablosundan hedef stok düzeyi 50'nin altýnda ve birim fiyatý 20'nin üstünde olan birim fiyatlarýný asc sýralayan sorgu

select * from Urunler where HedefStokDuzeyi<50 and BirimFiyati>20 order by BirimFiyati asc

-- Ürün adýnýn içinde c bulunan sorgu
select * from Urunler where UrunAdi like '%c%'

-- ürün adýnýn A ile baþlayan sonuçlarý veren sorgu
select * from Urunler where UrunAdi like 'A%'

-- ürün adýnýn s ile biten sonuçlarý veren sorgu
select * from Urunler where UrunAdi like '%s'

-- adýnýn ikinci harfi h dördüncü harfi e olan sonuçlarý veren sorgu
select * from Urunler where UrunAdi like '_h_e'

-- adýnýn ikinci harfi o beþinci harfi u olan sonuçlarý veren sorgu
select * from Urunler where UrunAdi like '_o__u'

-- Ürün adý a ile t arasýndaki ve son harfi a ile biten sonuçlarý veren sorgu
select * from Urunler where UrunAdi like '[a-t]%' and UrunAdi like '%a'
 

--satýþlar tablosunda sevk adý a-k arasýnda baþlayan ve sevk þehri ise e-s harflari arasýnda biten sorgularý yazýn.
select * from Satislar where SevkAdi like '[e-s]%' and SevkSehri like '%[e-s]'

select KategoriAdi as Katalog, Tanimi as 'Katalog Açýklamasý' from Kategoriler
/*
kategorilerden kategori adýný katalog yap tanýmýný katalog açýklamasý yap. tek kelime olduðunda direk yazýlabilir
Birden fazla kelimede týrnak içinde yazýlmalýdýr. Bu yaptýðýmýz geçici bir isim verir.
*/

select NakliyeUcreti as 'Asýl Fiyat' , NakliyeUcreti+1000 as 'Zamlý Fiyat' from Satislar

/*
Nakliye ücretini ilk baþta asýl fiyat olarak deðiþtirdi daha sonra ücretine 1000 ekleyerek nakliye ücretini
zamlý fiyat olarak gösterdi.
*/

--BETWEEN

select * from Urunler where UrunAdi between 'a' and 'f' -- Baþ harfi a ve f arasýnda.

select * from [Satis Detaylari] where Miktar between 10 and 100

-- satýþ detaylarýndan miktarý 10 lie 100 arasýnda olanlarý göster 
-- köþeli parantezi satýþ detaylarý arasýnda boþluk olduðu için kullanýyoruz.

select top 20 * from Musteriler order by MusteriID asc
-- ilk 20 müþteri ID'sini küçükten büyüðe doðru sýralý gösterir

select top 50 percent * from Musteriler where MusteriUnvani <> 'Owner' order by PostaKodu asc
--posta koduna göre sýrala müþteri ünvaný owner olanlarý tespit et 
--bulduklarýný çýkar bulduklarýnýn da yüzde 50 sþnþ göster
-- <> bu iþaret olmayanlarý al demektir.

select top 20 percent * from Personeller where SoyAdi <> 'Fuller' order by PostaKodu desc
-- posta kodunu büyükten küçüðe sýrala soyadý Fuller olanlarý çýkar.
-- Sonucun %20 olanlarý göster

select top 20 percent * from Urunler where UrunAdi <> 'Chai' order by BirimFiyati asc 
--urunadi Chai olanlarý çýkar, birim fiyat küçükten büyüðe doðru sýrala ve çýkardýklarýnýn yüzde 20'sini gösteren sorgu

select PersonelID, Adi, LEN(Adi) as 'Ýsim Uzunluðu', SoyAdi, LEN(SoyAdi) as 'Soyisim Uzunluðu'  from Personeller
--personellerden adi'ni isim uzunluðu olarak soyadýný soyisim uzunluðu olarak deðiþtir ve karakter sayýsýný gösteren sorgudur.

