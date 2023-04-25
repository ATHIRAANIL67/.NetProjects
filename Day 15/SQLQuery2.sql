/* Get the records of BankTB in given format
[ACNO]  [Account Holder Name] [Balance]  [Ref Acno] [Name of Referer]*/


select * from BankTB;

select a.accountno as ACNO, a.name as [Account Holder Name],
a.Balance, a.refaccno as [Ref Acno], r.name as [Name of Referer]
from banktb a join banktb r 
on a.refaccno=r.accountno;

select a.accountno as ACNO, a.name as [Account Holder Name],
a.Balance, a.refaccno as [Ref Acno], r.name as [Name of Referer]
from banktb a left outer join banktb r 
on a.refaccno=r.accountno;

select a.accountno as ACNO, a.name as [Account Holder Name],
a.Balance, a.refaccno as [Ref Acno], r.name as [Name of Referer]
from banktb a right outer join banktb r 
on a.refaccno=r.accountno;



select a.accountno as ACNO, a.name as [Account Holder Name],
a.Balance, a.refaccno as [Ref Acno], r.name as [Name of Referer]
from banktb a full outer join banktb r 
on a.refaccno=r.accountno;
