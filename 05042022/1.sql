truncate table Esyalar
delete from Esyalar
--Delete mant���yla �al���r.

/*
keys 
pk(primary key): birincil anahtar. Se�ili alanlar�n benzersiz olma �art� vard�r. pk olan alan her tabloda sadece ve
sadece bir tane olmak zorundad�r.

fk(foreign key) (yabanc�l, ikincil anahtar) : ili�ki tablolar�nda ba�lant� kurmak i�in yap�l�r. 

uq (unique key): pk mant���nda �al���r fakat birden fazla alan� uq tan�mlayabiliri. Se�ili kolonu benzersiz yapar.
*/

/*
�li�kiler

1) Bire - bir ili�kiler: (1-1) pk-pk
2) Bire - �ok ili�kiler: (1-n) pk-fk
3) �oka - �ok ili�kiler: (n-n) arada bir arac� tablo ve pk-fk (bire �ok ) ili�ki mant���yla yap�l�r.
*/

/*
Normalizasyon Kurallar�: Tablo olu�tururken uyulmas� gereken temel kurallar

1NF--> Birincil Normalizasyon: veri tekrar�, veri karma�as� veri b�t�nl���n� sa�lamak i�in 1nf kural� uygulan�r.
2NF--> 1NF'yi kapsar ve ayriyetn her tabloda pk olmas�n� ister
3NF--> 2NF'yi kapsar. Ayn� zamanda tablolar aras�nda ili�ki ve pk-fk ba�lant�s�n�n olmas�n� ister.
*/