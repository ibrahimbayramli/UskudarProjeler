-- tapular tablosundan konum adý istanbul olanlarýn vergi sicil nolarýný desc olarak sýrala
select * from Tapular where KonumAdi='Ýstanbul' order by VergiSicilNo desc

-- vergiler tablosundan vergi adý binek ise ve vergi aracý kamyon olanlarýn vergi dairelerini gösteren sorgu
select VergiDairesi from Vergiler where VergiAdi='binek' and VergiAraci='kamyon'

-- vatandaþlar tablosundan yaþý 18 den küçük olanlarýn telefon ve maillerini getirin.
select Telefon,Mail from Vatandaslar where Yas<18 

--nüfuslar tablosundan medeni hali bekar olanlarýn seri numaralarýný asc olarak sýralayan sorgu
select * from Nufus where MedeniHal='bekar' order by SeriNo asc

--vatandaþlar tablosundan ad soyad içerisinde nihal geçenleri getiren sorgu
select * from Vatandaslar where AdSoyad like '%nihal%'

-- vergiler tablosundan vergi adý a-f arasýnda baþlayanlarý ve vergi dairesi a-g arasýnda bitenleri getiren sorgu
select * from Vergiler where VergiAdi like '[a-f]%' and VergiDairesi like '%[a-g]'

-- nüfus tablosundan kütüðü sivas olanlarý cilt numaralarýný 2 þer tane arttýrýn (select ile)
select CiltNo+2 as CiltNo  from Nufus where KutukNo ='Sivas'
-- vergiler tablosundan vergi dairesi kolonu boþ olanlarý ve vergi adý kolonu boþ olanlarý getiren sorgu.
select * from Vergiler where VergiDairesi is null and VergiAdi is null