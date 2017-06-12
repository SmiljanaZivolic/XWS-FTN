/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     6/7/2017 1:09:50 PM                          */
/*==============================================================*/


if exists (select 1
            from  sysobjects
           where  id = object_id('IZVOD')
            and   type = 'U')
   drop table IZVOD
go

/*==============================================================*/
/* Table: IZVOD                                                 */
/*==============================================================*/
create table IZVOD (
   IZVOD_ID             int IDENTITY(1,1)                 not null,
   SVRHA_PLACANJA       varchar(255)         null,
   DUZNIK               varchar(255)         null,
   PRIMALAC             varchar(255)         null,
   DATUM_NALOGA         datetime             null,
   DATUM_VALUTE         datetime             null,
   RACUN_DUZNIKA        varchar(18)          null,
   MODEL_ZADUZENJA      numeric(2)           null,
   POZIV_NA_BROJ_ZADUZENJA varchar(20)          null,
   RACUN_POVERIOCA      varchar(18)          null,
   MODEL_ODOBRENJA      numeric(2)           null,
   POZIV_NA_BROJ_ODOBRENJA varchar(20)          null,
   IZNOS                decimal(15,2)        null,
   constraint PK_IZVOD primary key nonclustered (IZVOD_ID)
)
go

