/*
Order by
order by ile s�ralama yap�l�r. 
*/

select * from Musteriler order by MusteriAdi Desc --Z'den A'ya do�ru s�ralama yapar.

select * from Musteriler order by MusteriAdi asc --A'dan Z'ye do�ru s�ralama yapar.

select MusteriAdi,MusteriUnvani from Musteriler order by MusteriUnvani asc

-- sat��lar tablosundan nakliye �creti 100'�n alt�nda olanlar� sat�� tarihlerini desc olarak s�ralay�n�z.
select * from Satislar where NakliyeUcreti<100 order by SatisTarihi desc

--�r�nler tablosundan hedef stok d�zeyi 50'nin alt�nda ve birim fiyat� 20'nin �st�nde olan birim fiyatlar�n� asc s�ralayan sorgu

select * from Urunler where HedefStokDuzeyi<50 and BirimFiyati>20 order by BirimFiyati asc

-- �r�n ad�n�n i�inde c bulunan sorgu
select * from Urunler where UrunAdi like '%c%'

-- �r�n ad�n�n A ile ba�layan sonu�lar� veren sorgu
select * from Urunler where UrunAdi like 'A%'

-- �r�n ad�n�n s ile biten sonu�lar� veren sorgu
select * from Urunler where UrunAdi like '%s'

-- ad�n�n ikinci harfi h d�rd�nc� harfi e olan sonu�lar� veren sorgu
select * from Urunler where UrunAdi like '_h_e'

-- ad�n�n ikinci harfi o be�inci harfi u olan sonu�lar� veren sorgu
select * from Urunler where UrunAdi like '_o__u'

-- �r�n ad� a ile t aras�ndaki ve son harfi a ile biten sonu�lar� veren sorgu
select * from Urunler where UrunAdi like '[a-t]%' and UrunAdi like '%a'
 

--sat��lar tablosunda sevk ad� a-k aras�nda ba�layan ve sevk �ehri ise e-s harflari aras�nda biten sorgular� yaz�n.
select * from Satislar where SevkAdi like '[e-s]%' and SevkSehri like '%[e-s]'

select KategoriAdi as Katalog, Tanimi as 'Katalog A��klamas�' from Kategoriler
/*
kategorilerden kategori ad�n� katalog yap tan�m�n� katalog a��klamas� yap. tek kelime oldu�unda direk yaz�labilir
Birden fazla kelimede t�rnak i�inde yaz�lmal�d�r. Bu yapt���m�z ge�ici bir isim verir.
*/

select NakliyeUcreti as 'As�l Fiyat' , NakliyeUcreti+1000 as 'Zaml� Fiyat' from Satislar

/*
Nakliye �cretini ilk ba�ta as�l fiyat olarak de�i�tirdi daha sonra �cretine 1000 ekleyerek nakliye �cretini
zaml� fiyat olarak g�sterdi.
*/

--BETWEEN

select * from Urunler where UrunAdi between 'a' and 'f' -- Ba� harfi a ve f aras�nda.

select * from [Satis Detaylari] where Miktar between 10 and 100

-- sat�� detaylar�ndan miktar� 10 lie 100 aras�nda olanlar� g�ster 
-- k��eli parantezi sat�� detaylar� aras�nda bo�luk oldu�u i�in kullan�yoruz.

select top 20 * from Musteriler order by MusteriID asc
-- ilk 20 m��teri ID'sini k���kten b�y��e do�ru s�ral� g�sterir

select top 50 percent * from Musteriler where MusteriUnvani <> 'Owner' order by PostaKodu asc
--posta koduna g�re s�rala m��teri �nvan� owner olanlar� tespit et 
--bulduklar�n� ��kar bulduklar�n�n da y�zde 50 s�n� g�ster
-- <> bu i�aret olmayanlar� al demektir.

select top 20 percent * from Personeller where SoyAdi <> 'Fuller' order by PostaKodu desc
-- posta kodunu b�y�kten k����e s�rala soyad� Fuller olanlar� ��kar.
-- Sonucun %20 olanlar� g�ster

select top 20 percent * from Urunler where UrunAdi <> 'Chai' order by BirimFiyati asc 
--urunadi Chai olanlar� ��kar, birim fiyat k���kten b�y��e do�ru s�rala ve ��kard�klar�n�n y�zde 20'sini g�steren sorgu

select PersonelID, Adi, LEN(Adi) as '�sim Uzunlu�u', SoyAdi, LEN(SoyAdi) as 'Soyisim Uzunlu�u'  from Personeller
--personellerden adi'ni isim uzunlu�u olarak soyad�n� soyisim uzunlu�u olarak de�i�tir ve karakter say�s�n� g�steren sorgudur.

