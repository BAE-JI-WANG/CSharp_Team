/****** SSMS의 SelectTopNRows 명령 스크립트 ******/
SELECT TOP (1000) [name]
      ,[gender]
      ,[id]
      ,[pwd]
      ,[email]
      ,[phone]
  FROM [Csharp_Team].[dbo].[member]

  delete from member where id=''

  ALTER TABLE member ADD CONSTRAINT id_p PRIMARY KEY (id)

  use Csharp_Team;
  
  select * from member where id=''
