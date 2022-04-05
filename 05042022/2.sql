insert into Banka(BankaAdi,BankaNo,BankaSicilNo)
values('Ziraat',001,1097)
insert into Banka(BankaAdi,BankaNo,BankaSicilNo)
values('Ýþ Bank',0012,8797)
insert into Banka(BankaAdi,BankaNo,BankaSicilNo)
values('Finansbank',36,2224)
insert into Banka(BankaAdi,BankaNo,BankaSicilNo)
values('Halk Bank',32,225424)
insert into Banka(BankaAdi,BankaNo,BankaSicilNo)
values('Odeobank',123,2132253424)

update Banka
set BankaAdi='Odeo Bank'
where BankaNo=123

update Banka
set BankaAdi='Halk Bankasý'
where BankaNo=32

update Banka
set BankaAdi='Türkiye ÝÞ Bankasý'
where BankaNo=0012

update Banka
set BankaAdi='Finans Bank'
where BankaNo=36

update Banka
set BankaAdi='Ziraat Bankasý'
where BankaNo=001

delete from Banka where BankaAdi='Odeo Bank'

delete from Banka where BankaAdi='Finans Bank'