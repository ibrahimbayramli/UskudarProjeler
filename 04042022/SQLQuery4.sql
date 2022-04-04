create database Sirket

create table Personel(
personelNo int,
adSoyad varchar(50),
yas int,
maas int,
adres varchar(50),
il varchar(20)

)

alter table Personel add tcNo nchar(11)
alter table Personel add dogumTarihi date

alter table Personel drop column personelNo