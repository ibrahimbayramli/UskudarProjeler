--�r�nler tablosundan �r�n ad�na g�re grupland�rma yap�p hedef stok d�zeyi ortalamas�n� alan sorguyu yaz.

select AVG(HedefStokDuzeyi) from Urunler group by UrunAdi

--�r�nler tablosundan hedef stok d�zeyi 42 den k���k olanlar� �r�n ad�na g�re grupland�r�p birim fiyat�n�n toplam�n� veren sorgu

select sum(BirimFiyati) from Urunler where HedefStokDuzeyi<42 group by UrunAdi