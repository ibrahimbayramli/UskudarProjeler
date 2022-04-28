CREATE PROC [dbo].[HizmetEkle]
@HizmetNo int,
@HizmetAdi varchar(50),
@HizmetTanimi varchar(50),
@HizmetFiyat money,
@OzellikNo int
AS BEGIN

INSERT INTO Hizmetler (HizmetNo,HizmetAdi,HizmetTanimi,HizmetFiyat,OzellikNo)
VALUES (@HizmetNo,@HizmetAdi,@HizmetTanimi,@HizmetFiyat,@OzellikNo)
END

CREATE PROC [dbo].[HizmetGuncelle]
@HizmetNo int,
@HizmetAdi varchar(50),
@HizmetTanimi varchar(50),
@HizmetFiyat money
AS BEGIN

UPDATE Hizmetler SET HizmetAdi=@HizmetAdi,HizmetTanimi=@HizmetTanimi,HizmetFiyat=@HizmetFiyat 
WHERE HizmetNo=@HizmetNo
END

CREATE PROC [dbo].[HizmetListele]
AS BEGIN
SELECT * FROM Hizmetler
END

CREATE PROC [dbo].[HizmetOzellikEkle]
@OzellikNo int,
@OzellikAciklama varchar(50),
@OzellikEkstra varchar(50)

AS BEGIN

INSERT INTO HizmetOzellik(OzellikNo,OzellikAciklama,OzellikEkstra)
VALUES (@OzellikNo,@OzellikAciklama,@OzellikEkstra)
END

CREATE PROC [dbo].[HizmetOzellikGuncelle]
@OzellikNo int,
@OzellikAciklama varchar(50),
@OzellikEkstra varchar(50)

AS BEGIN

UPDATE HizmetOzellik SET OzellikAciklama=@OzellikAciklama,OzellikEkstra=@OzellikEkstra 
WHERE OzellikNo=@OzellikNo
END

CREATE PROC [dbo].[HizmetOzellikListele]
AS BEGIN
SELECT * FROM HizmetOzellik
END

CREATE PROC [dbo].[HizmetOzellikSil]
@OzellikNo int
AS BEGIN
DELETE FROM HizmetOzellik WHERE OzellikNo=@OzellikNo
END

CREATE PROC [dbo].[HizmetSil]
@HizmetNo int
AS BEGIN
DELETE FROM Hizmetler WHERE HizmetNo=@HizmetNo
END