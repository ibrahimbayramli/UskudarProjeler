
select UretimAdi,UretimGelir from Uretim where UretimYeri='Ýstanbul'


select top 3* from Uretim where UretimYeri!='Ankara' order by UretimGider desc


select UretimGelir+100 as 'Üretim Geliri' from Uretim where UretimAdi='Dýþ giyim'

 
select * from Uretim where UretimGider>0 and UretimGider<200 order by UretimGider desc


select sum(UretimGelir) as 'Üretim Geliri' , UretimAdi from Uretim group by UretimAdi


select MAX(UretimGider)as 'Maksimum',UretimAdi,UretimYeri from Uretim group by  UretimYeri

select min(UretimGider) as 'Min' ,UretimYeri from Uretim group by UretimYeri

select min(UretimGider) as 'Min' ,UretimYeri from Uretim group by UretimYeri
