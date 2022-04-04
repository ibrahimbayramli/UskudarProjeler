-- MSSQL

--ddl (data definition language)
-- (veri tanımlama komutları)
--crate --> oluşturmak
--alter --> oluşturulan alanlarda değişiklik yapmak istediğimizde kullanırız.
--drop --> silme, yoketme anlamında kullanılır. (fiziki yapıda çalışır.)

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