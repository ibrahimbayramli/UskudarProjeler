--mesleklere g�re grupland�r�p ortalama maa�lar� getirir.
select avg(Maas) as 'Ortalama Maa�' , Meslek from Personeller group by Meslek
select * from Personeller

-- sigorta durumuna g�re grupland�r�p en k���k ya�lar� getirir
select min(Yas) as Ya� , SigortaDurumu from [dbo].[Personeller] group by SigortaDurumu

--memlekete g�re grupland�rma yap�p maa�lar�n toplam�n� veren sorgu
select sum(Maas)as maas ,Memleket from [dbo].[Personeller] group by Memleket
