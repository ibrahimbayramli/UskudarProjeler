--ürünler tablosundan ürün adýna göre gruplandýrma yapýp hedef stok düzeyi ortalamasýný alan sorguyu yaz.

select AVG(HedefStokDuzeyi) from Urunler group by UrunAdi

--ürünler tablosundan hedef stok düzeyi 42 den küçük olanlarý ürün adýna göre gruplandýrýp birim fiyatýnýn toplamýný veren sorgu

select sum(BirimFiyati) from Urunler where HedefStokDuzeyi<42 group by UrunAdi