/*
Stored Procedure
1) H�z

Stored Procedure olu�turdu�umuzda bu sorguyu bir kere �al��t�rd���m�zda sistem derler ve sonrakilerde tekrar tekrar �al��t�r�lmaz. Daha �nce �al��t�r�ld���nda haf�zaya al�r ve oradan tekrardan �al��t�r�r. Normal sorgu �al��t�rmak istedi�imizde ise bunu her seferinde ilk kez kar��la�m�� gibi yeniden �al��t�r�r. Bu da h�z a��s�ndan pek avantajl� de�ildir.

2) Parametre Kullan�m�

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

exec Pekle '�brahim BAYRAMLI','M�hendis',29,25000,9000,'Kars',1