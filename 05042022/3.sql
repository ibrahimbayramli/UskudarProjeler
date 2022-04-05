/*

dml
select
insert
update
delete

*/

select * from Urunler --tablonun tüm kolonlarýný getirir.

select * from Urunler where UrunAdi='pavlova'

select * from Urunler where BirimFiyati>10 and BirimFiyati<20

select * from Urunler  where UrunAdi='Chang' and HedefStokDuzeyi<20 and BirimFiyati>10

select SevkAdi,OdemeTarihi from Satislar where NakliyeUcreti>20 

select * from Satislar where SevkPostaKodu=1081 and SevkUlkesi='venezuela'

-- Tabloda boþ olan karakterleri gösterir.
select * from Musteriler where MusteriAdi is null

-- Tabloda boþ olmayan karakterleri gösterir.
select * from Satislar where SevkPostaKodu is not null
select * from Satislar where SevkPostaKodu is not null and SevkBolgesi is null


-- OR (veya)
-- OR birden fazla koþulda kullanýlýr.

select * from personeller where PersonelID=1 or PersonelID=2 or PersonelID=4

-- OR'daki koþulu sürekli tekrarlamak yerine bir kere yazmak için IN kullanýlýr.

select * from Personeller where PersonelID in(1,2,4)

select * from Urunler where UrunAdi='chai'
update Urunler set HedefStokDuzeyi+=20 where UrunAdi='chai'
select * from Urunler where UrunAdi='chai' 

select * from Urunler where UrunAdi='Ikura'
update Urunler set HedefStokDuzeyi-=10 where UrunAdi='Ikura'
select * from Urunler where UrunAdi='Ikura' 