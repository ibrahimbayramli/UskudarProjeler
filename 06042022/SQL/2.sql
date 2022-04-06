-- tapular tablosundan konum ad� istanbul olanlar�n vergi sicil nolar�n� desc olarak s�rala
select * from Tapular where KonumAdi='�stanbul' order by VergiSicilNo desc

-- vergiler tablosundan vergi ad� binek ise ve vergi arac� kamyon olanlar�n vergi dairelerini g�steren sorgu
select VergiDairesi from Vergiler where VergiAdi='binek' and VergiAraci='kamyon'

-- vatanda�lar tablosundan ya�� 18 den k���k olanlar�n telefon ve maillerini getirin.
select Telefon,Mail from Vatandaslar where Yas<18 

--n�fuslar tablosundan medeni hali bekar olanlar�n seri numaralar�n� asc olarak s�ralayan sorgu
select * from Nufus where MedeniHal='bekar' order by SeriNo asc

--vatanda�lar tablosundan ad soyad i�erisinde nihal ge�enleri getiren sorgu
select * from Vatandaslar where AdSoyad like '%nihal%'

-- vergiler tablosundan vergi ad� a-f aras�nda ba�layanlar� ve vergi dairesi a-g aras�nda bitenleri getiren sorgu
select * from Vergiler where VergiAdi like '[a-f]%' and VergiDairesi like '%[a-g]'

-- n�fus tablosundan k�t��� sivas olanlar� cilt numaralar�n� 2 �er tane artt�r�n (select ile)
select CiltNo+2 as CiltNo  from Nufus where KutukNo ='Sivas'
-- vergiler tablosundan vergi dairesi kolonu bo� olanlar� ve vergi ad� kolonu bo� olanlar� getiren sorgu.
select * from Vergiler where VergiDairesi is null and VergiAdi is null