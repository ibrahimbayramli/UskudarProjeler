-- MSSQL

--ddl (data definition language)
-- (veri tanýmlama komutlarý)
--crate --> oluþturmak
--alter --> oluþturulan alanlarda deðiþiklik yapmak istediðimizde kullanýrýz.
--drop --> silme, yoketme anlamýnda kullanýlýr. (fiziki yapýda çalýþýr.)

create database Universite

create table Ogrenciler(
OgrenciNo int,
AdSoyad varchar(50),
adres varchar(100),
telefon char(11),


)

create table Hocalar(
HocaNo int not null,
adsoyad nvarchar(20),
maas money not null,
isegiris datetime not null,
telefon nchar(11),
tcno char(11) not null,
durum bit
)


-- dml()