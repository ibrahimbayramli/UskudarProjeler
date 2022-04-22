ALTER TABLE Kitaplar
ADD CONSTRAINT df_KitapYazar
DEFAULT 'Oðuz ATAY' FOR KitapYazar;

ALTER TABLE Kitaplar
ADD CONSTRAINT df_KitapAdi
DEFAULT 'Tutunamayanlar' FOR KitapAdi;

ALTER TABLE Kitaplar
ADD CONSTRAINT uk_Kitaplar_BarkodNO UNIQUE (BarkodNO)

ALTER TABLE Kitaplar
ADD CONSTRAINT uk_Kitaplar_YayinciNo UNIQUE (YayinciNo)

ALTER TABLE Kitaplar
ADD CONSTRAINT CHK_Puan CHECK (Puan>=1 AND Puan<=5)

ALTER TABLE Kitaplar
ADD CONSTRAINT CHK_Fiyat CHECK (Puan>=0 AND Puan<=100)