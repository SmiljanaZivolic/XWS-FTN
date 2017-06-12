USE [XWS]
GO

INSERT INTO [dbo].[FAKTURA]
           ([ID_PORUKE]
           ,[NAZIV_DOBAVLJACA]
           ,[ADRESA_DOBAVLJACA]
           ,[PIB_DOBAVLJACA]
           ,[NAZIV_KUPCA]
           ,[ADRESA_KUPCA]
           ,[PIB_KUPCA]
           ,[BROJ_RACUNA]
           ,[DATUM_RACUNA]
           ,[VREDNOST_ROBE]
           ,[VREDNOST_USLUGE]
           ,[UKUPNO_ROBE_I_USLUGA]
           ,[UKUPAN_RABAT]
           ,[UKUPAN_POREZ]
           ,[OZNAKA_VALUTE]
           ,[IZNOS_ZA_UPLATU]
           ,[UPLATA_NA_RACUN]
           ,[DATUM_VALUTE])
     VALUES
           ('id1'
           ,'firmaA'
           ,'adresaA'
           ,'1111111'
           ,'firmaB'
           ,'adresaB'
           ,'2222222'
           ,'1'
           ,SYSDATETIME()
           ,100
           ,100
           ,200
           ,0
           ,40
           ,'rsd'
           ,200
           ,'456-123'
           ,SYSDATETIME())
GO

