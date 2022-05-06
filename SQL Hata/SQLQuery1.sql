-- XML veri çýkarma

SELECT UrunID, UrunAdi, BirimFiyati FROM Urunler FOR XML AUTO

--------------------------------------------------------------------------------------

SELECT top 5 UrunID,UrunAdi,BirimFiyati FROM Urunler 
FOR XML AUTO, ROOT('RootNode')

--------------------------------------------------------------------------------------

SELECT TOP 10 UrunID,UrunAdi,BirimFiyati,Tanimi FROM Urunler
INNER JOIN Kategoriler ON Urunler.KategoriID=Kategoriler.KategoriID
FOR XML AUTO, ROOT('RootNode')

--------------------------------------------------------------------------------------

SELECT TOP 5 UrunID, UrunAdi, BirimFiyati FROM Urunler
FOR XML RAW('Mamüller'),ROOT('RootNode')

/*
	Çýktýmýzda gördüðümüz gibi ürünler olarak belirttiðimiz element adý XML çýktýðýmýzda görünmektedir. Eðer RAW ifadesi beraber herhangi
	bir element adý belirtilmezse SQL SERVER otomatik olarak bizim yerimize ROW adý belirtilmezse SQL SERVER otomatik olarak bizim 
	ROW adlý elementini kullanacaktýr.
*/

SELECT TOP 5 UrunID,UrunAdi,BirimFiyati FROM Urunler
FOR JSON AUTO, ROOT ('RootNode')

-- SQL Hata yakalama
BEGIN TRY
SELECT a=1
SELECT b=5
SELECT c=3/0
END TRY
BEGIN CATCH
PRINT 'Hata Mesajý'
END CATCH

BEGIN TRY
SELECT sonuc=5/0
END TRY
BEGIN CATCH
SELECT [Hata_Satiri]=ERROR_LINE(),
[Hata_Sayisi]=ERROR_NUMBER(),
[Hata_Onemi]=ERROR_SEVERITY(),
[Hata_Durumu]=ERROR_STATE()
SELECT [Hata_Mesaji]=ERROR_MESSAGE()
END CATCH

BEGIN TRY
EXEC Ornek_Procedure
END TRY
BEGIN CATCH
SELECT Hata_Satiri=ERROR_LINE(),
Procedure_Adi=ERROR_PROCEDURE()
SELECT Hata_Mesaji=ERROR_MESSAGE()
END CATCH