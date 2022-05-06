-- XML veri ��karma

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
FOR XML RAW('Mam�ller'),ROOT('RootNode')

/*
	��kt�m�zda g�rd���m�z gibi �r�nler olarak belirtti�imiz element ad� XML ��kt���m�zda g�r�nmektedir. E�er RAW ifadesi beraber herhangi
	bir element ad� belirtilmezse SQL SERVER otomatik olarak bizim yerimize ROW ad� belirtilmezse SQL SERVER otomatik olarak bizim 
	ROW adl� elementini kullanacakt�r.
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
PRINT 'Hata Mesaj�'
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