/* 
K�meleme fonksiyonlar� (aggrreate)
1) max() --> se�ilen kolonun en b�y���n� getirir.
2) min() --> se�ilen kolonun en k���k��n� getirir.
3) sum() --> se�ilen kolonun t�m de�erlerini toplar.
4) avg() --> se�ilen kolonun ortalamas�n� getirir.
5) count() --> se�ilen kolonun adetini sayar.
6) count(*) --> t�m kolonun adetini getirir.
*/

select sum(BirimFiyati) as 'Fiyat Bedeli' from Urunler
select avg(HedefStokDuzeyi) from Urunler
select COUNT(YeniSatis) from Urunler
select COUNT(*) from Urunler
select min(BirimFiyati) from Urunler
select max(BirimFiyati) from Urunler