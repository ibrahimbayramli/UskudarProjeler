-- tedarik�iler, kategori ve �r�nler aras�nda join 

select * from Tedarikciler t inner join Urunler u on t.TedarikciID=u.TedarikciID inner join Kategoriler k on u.KategoriID=k.KategoriID

select * from Musteriler m inner join Satislar s on m.MusteriID=s.MusteriID inner join Personeller p on p.PersonelID =s.PersonelID order by s.NakliyeUcreti desc

--sat��lar ile nakliyeciler tablolar�n� birbirine ba�la sonra da sat��lar ile personeller i�e ilk ba�layan ki�inin �nvan�n� i�e ba�lama tarihi, sevk ad�n� ,�irket ad�n� ve telefonunu g�steren sorgu nakliye �creti >500 olanlar� getir
select top 1 Adi,SoyAdi,Unvan, IseBaslamaTarihi,SevkAdi,SirketAdi,Telefon from Satislar s inner join Nakliyeciler n on s.ShipVia=n.NakliyeciID inner join Personeller p on s.PersonelID=p.PersonelID where NakliyeUcreti> 500 order by IseBaslamaTarihi 

 