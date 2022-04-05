truncate table Esyalar
delete from Esyalar
--Delete mantýðýyla çalýþýr.

/*
keys 
pk(primary key): birincil anahtar. Seçili alanlarýn benzersiz olma þartý vardýr. pk olan alan her tabloda sadece ve
sadece bir tane olmak zorundadýr.

fk(foreign key) (yabancýl, ikincil anahtar) : iliþki tablolarýnda baðlantý kurmak için yapýlýr. 

uq (unique key): pk mantýðýnda çalýþýr fakat birden fazla alaný uq tanýmlayabiliri. Seçili kolonu benzersiz yapar.
*/

/*
Ýliþkiler

1) Bire - bir iliþkiler: (1-1) pk-pk
2) Bire - çok iliþkiler: (1-n) pk-fk
3) Çoka - çok iliþkiler: (n-n) arada bir aracý tablo ve pk-fk (bire çok ) iliþki mantýðýyla yapýlýr.
*/

/*
Normalizasyon Kurallarý: Tablo oluþtururken uyulmasý gereken temel kurallar

1NF--> Birincil Normalizasyon: veri tekrarý, veri karmaþasý veri bütünlüðünü saðlamak için 1nf kuralý uygulanýr.
2NF--> 1NF'yi kapsar ve ayriyetn her tabloda pk olmasýný ister
3NF--> 2NF'yi kapsar. Ayný zamanda tablolar arasýnda iliþki ve pk-fk baðlantýsýnýn olmasýný ister.
*/