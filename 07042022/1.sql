--urunler tablosundan urun adina gore gruplandirma yapip hedef stok duzeyi ortalamasini alan sorguyu yaz.

select AVG(HedefStokDuzeyi) from Urunler group by UrunAdi

--urunler tablosundan hedef stok duzeyi 42 den ku�uk olanlari urun adina gore gruplandirip birim fiyatinin toplamini veren sorguyu yaziniz

select sum(BirimFiyati) from Urunler where HedefStokDuzeyi<42 group by UrunAdi