/*
Stored Procedure
1) Hýz

Stored Procedure oluþturduðumuzda bu sorguyu bir kere çalýþtýrdýðýmýzda sistem derler ve sonrakilerde tekrar tekrar çalýþtýrýlmaz. Daha önce çalýþtýrýldýðýnda hafýzaya alýr ve oradan tekrardan çalýþtýrýr. Normal sorgu çalýþtýrmak istediðimizde ise bunu her seferinde ilk kez karþýlaþmýþ gibi yeniden çalýþtýrýr. Bu da hýz açýsýndan pek avantajlý deðildir.

2) Parametre Kullanýmý

3) Esneklik
*/

--Stored Procedure

create proc Pekle
@AdSoyad varchar(50),
@Meslek varchar(50),
@PersonelNo int,
@Yas int,
@Maas money,
@Prim money,
@Memleket varchar(50)
as begin
insert into Personeller (AdSoyad,Meslek,Yas,Maas,Pirim,Memleket,PersonelNo)
values(@AdSoyad,@Meslek,@Yas,@Maas,@Prim,@Memleket,@PersonelNo)
end

exec Pekle 'Ýbrahim BAYRAMLI','Mühendis',29,25000,9000,'Kars',1