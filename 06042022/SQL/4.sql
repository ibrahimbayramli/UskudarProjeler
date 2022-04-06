--mesleklere göre gruplandýrýp ortalama maaþlarý getirir.
select avg(Maas) as 'Ortalama Maaþ' , Meslek from Personeller group by Meslek
select * from Personeller

-- sigorta durumuna göre gruplandýrýp en küçük yaþlarý getirir
select min(Yas) as Yaþ , SigortaDurumu from [dbo].[Personeller] group by SigortaDurumu

--memlekete göre gruplandýrma yapýp maaþlarýn toplamýný veren sorgu
select sum(Maas)as maas ,Memleket from [dbo].[Personeller] group by Memleket
