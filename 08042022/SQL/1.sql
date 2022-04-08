/*
Stored Procedure
1) Hız

Stored Procedure olusturdugumuzda bu sorguyu bir kere calistirdigimizda sistem derler ve sonrakilerde tekrar tekrar çalistirilmaz. Daha once calistirildiğinda hafizaya alir ve oradan tekrardan calıştirir. Normal sorgu calistirmak istedigimizde ise bunu her seferinde ilk kez karsilasmis gibi yeniden calistirir. Bu da hiz acisindan pek avantajli degildir.

2) Parametre Kullanımı

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

exec Pekle 100,'İbrahim BAYRAMLI','Mühendis',29,25000,9000,'Kars'

--proc veya procedure ikisi de kullanılabilir.
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

exec AramaYap 'İbrahim BAYRAMLI'

--Yasi 25 den buyuk 30 dan kucuk olanlari siralayan procedure

alter proc Sorgula
@UstSinir int, 
@AltSinir int
as begin
select * from Personeller where Yas<@UstSinir or Yas>@UstSinir
end 

exec Sorgula 25,30

