create database Bilgisayarlar
/*
aletno
marka
adet
fiyat
ozell
uretim tarihi
kategori adi
model
uretim yeri

*/

create table Aletler(
AletNO int primary key identity(1,1),
Marka varchar(50),
Adet int,
Fiyat money,
Ozellik varchar(50),
UretimTarihi date,
KategoriAdi varchar(50),
Model varchar(50),
UretimYeri varchar(50)
)

create proc VeriEkle
@Marka varchar(50),
@Adet int,
@Fiyat money,
@Ozellik varchar(50),
@KategoriAdi varchar(50),
@Model varchar(50),
@UretimYeri varchar(50)
as begin
insert into Aletler (Marka,Adet,Fiyat,Ozellik,KategoriAdi,Model,UretimYeri)
values(@Marka,@Adet,@Fiyat,@Ozellik,@KategoriAdi,@Model,@UretimYeri)
end

exec VeriEkle 'Logitech', 250,200,'Mause','Oyun','M330','Tayvan'


alter proc Zirve

as begin
select top 3 * from Aletler order by Fiyat asc
end

exec Zirve