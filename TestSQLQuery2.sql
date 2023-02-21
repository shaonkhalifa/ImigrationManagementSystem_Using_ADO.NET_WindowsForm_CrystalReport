 CREATE TABLE Visa
(
	visaId INT IDENTITY PRIMARY KEY,
	visaNumber NVARCHAR(40) UNIQUE ,
	issueDate DATETIME,
	expireDate DATETIME,
	duration    AS (expireDate-issueDate)
)
GO
select * from Visa
go

insert into Visa values('hj57673','01/05/2020','03/03/2022')
go

SELECT
  visaId,
  visaNumber,
  issueDate,
  expireDate,
  DATEDIFF(MONTH,issueDate, expireDate) AS date_difference
FROM Visa;