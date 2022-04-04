-- MSSQL

--ddl (data definition language)
-- (veri tan�mlama komutlar�)
--crate --> olu�turmak
--alter --> olu�turulan alanlarda de�i�iklik yapmak istedi�imizde kullan�r�z.
--drop --> silme, yoketme anlam�nda kullan�l�r. (fiziki yap�da �al���r.)

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