create proc OAdd
@AdSoyad varchar(50),
@TcNo char(11),
@Telefon nchar(11),
@Mail varchar(50),
@Adres varchar(50),
@DersNo int
as begin
insert into Ogrenciler (AdSoyad,TcNo,Telefon,Mail,Adres,DersNo)
values(@AdSoyad,@TcNo,@Telefon,@Mail,@Adres,@DersNo)
end

execute OAdd 'behinur','1454545','54545','nurlugirl@hotmail.com','sisli',1

create proc OY
@OgrenciNo int,
@AdSoyad varchar(50),
@TcNo char(11),
@Telefon nchar(11),
@Mail varchar(50),
@Adres varchar(50),
@DersNo int
as begin
update Ogrenciler set AdSoyad=@AdSoyad,TcNo=@TcNo,Telefon=@Telefon,Mail=@Mail,Adres=@Adres,DersNo=@DersNo where OgrenciNo=@OgrenciNo
end

create proc OSL
@OgrenciNo int
as begin
delete from Ogrenciler where OgrenciNo=@OgrenciNo
end

create proc OG
as begin
select * from Ogrenciler
end