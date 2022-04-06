/* 
Kümeleme fonksiyonlarý (aggrreate)
1) max() --> seçilen kolonun en büyüðünü getirir.
2) min() --> seçilen kolonun en küçükðünü getirir.
3) sum() --> seçilen kolonun tüm deðerlerini toplar.
4) avg() --> seçilen kolonun ortalamasýný getirir.
5) count() --> seçilen kolonun adetini sayar.
6) count(*) --> tüm kolonun adetini getirir.
*/

select sum(BirimFiyati) as 'Fiyat Bedeli' from Urunler
select avg(HedefStokDuzeyi) from Urunler
select COUNT(YeniSatis) from Urunler
select COUNT(*) from Urunler
select min(BirimFiyati) from Urunler
select max(BirimFiyati) from Urunler