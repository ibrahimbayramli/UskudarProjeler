/*
Stored Procedure
1) H�z

Stored Procedure olusturdugumuzda bu sorguyu bir kere calistirdigimizda sistem derler ve sonrakilerde tekrar tekrar �alistirilmaz. Daha once calistirildi�inda hafizaya alir ve oradan tekrardan cal��tirir. Normal sorgu calistirmak istedigimizde ise bunu her seferinde ilk kez karsilasmis gibi yeniden calistirir. Bu da hiz acisindan pek avantajli degildir.

2) Parametre Kullan�m�

3) Esneklik
*/

--Stored Procedure

alter proc Pekle
@PersonelNo int,
@AdSoyad varchar(50),
@Meslek varchar(50),
@Yas int,
@Maas money,
@Prim money,
@Memleket varchar(50)
as begin
insert into Personeller (PersonelNo,AdSoyad,Meslek,Yas,Maas,Pirim,Memleket)
values(@PersonelNo,@AdSoyad,@Meslek,@Yas,@Maas,@Prim,@Memleket)
end

exec Pekle 100,'�brahim BAYRAMLI','M�hendis',29,25000,9000,'Kars'

--proc veya procedure ikisi de kullan�labilir.
create proc VerileriCek 
as begin
select * from Personeller
end

exec VerileriCek

create procedure AramaYap
@AdSoyad varchar(50)
as begin
select * from Personeller where AdSoyad=@AdSoyad
end

exec AramaYap '�brahim BAYRAMLI'

--Yasi 25 den buyuk 30 dan kucuk olanlari siralayan procedure

alter proc Sorgula
@UstSinir int, 
@AltSinir int
as begin
select * from Personeller where Yas<@UstSinir and Yas>@AltSinir
end 

exec Sorgula 30,25

-- yenileme proc
create proc Pyenile
@PersonelNo int,
@AdSoyad varchar(50),
@Meslek varchar(50),
@Yas int,
@Maas money,
@Prim money,
@Memleket varchar(50)
as begin
update Personeller set AdSoyad=@AdSoyad,Meslek=@Meslek,Yas=@Yas,Maas=@Maas,Pirim=@Prim,Memleket=@Memleket where PersonelNo=@PersonelNo
end

exec Pyenile 100,'ibrahim bayramli','dev',49,1500,10,'istanbul'

exec VerileriCek

create proc Psil
@PersonelNo int
as begin
delete from Personeller where PersonelNo=@PersonelNo
end

exec Psil 100