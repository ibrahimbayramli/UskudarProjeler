--musteriler ve satislar tablosunu birbirine bagliyoruz. musterilerden musteri adi, musteri unvani ve musteri id kolonlarýný. satislardan ,shipvia, odeme tarihi ve sevk tarihi

select m.MusteriUnvani,m.MusteriAdi, m.MusteriID,s.ShipVia,s.OdemeTarihi,s.SevkTarihi from Satislar s inner join Musteriler m on s.MusteriID=m.MusteriID order by SevkTarihi asc