/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     6/5/2017 10:31:34 PM                         */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('RACUN') and o.name = 'FK_RACUN_RELATIONS_BANKA')
alter table RACUN
   drop constraint FK_RACUN_RELATIONS_BANKA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('STAVKA') and o.name = 'FK_STAVKA_RELATIONS_FAKTURA')
alter table STAVKA
   drop constraint FK_STAVKA_RELATIONS_FAKTURA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BANKA')
            and   type = 'U')
   drop table BANKA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('FAKTURA')
            and   type = 'U')
   drop table FAKTURA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('FIRMA')
            and   type = 'U')
   drop table FIRMA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('NALOG_PRENOS')
            and   type = 'U')
   drop table NALOG_PRENOS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('RACUN')
            and   type = 'U')
   drop table RACUN
go

if exists (select 1
            from  sysobjects
           where  id = object_id('STAVKA')
            and   type = 'U')
   drop table STAVKA
go

/*==============================================================*/
/* Table: BANKA                                                 */
/*==============================================================*/
create table BANKA (
   ID_BANKA             int   IDENTITY(1,1)               not null,
   NAZIV                varchar(255)         null,
   SWIFT                varchar(8)           null,
   RACUN                varchar(18)          null,
   constraint PK_BANKA primary key nonclustered (ID_BANKA)
)
go

/*==============================================================*/
/* Table: FAKTURA                                               */
/*==============================================================*/
create table FAKTURA (
   ID_FAKTURA           int  IDENTITY(1,1)                not null,
   ID_PORUKE            varchar(50)          null,
   NAZIV_DOBAVLJACA     varchar(255)         null,
   ADRESA_DOBAVLJACA    varchar(255)         null,
   PIB_DOBAVLJACA       varchar(11)          null,
   NAZIV_KUPCA          varchar(255)         null,
   ADRESA_KUPCA         varchar(255)         null,
   PIB_KUPCA            varchar(11)          null,
   BROJ_RACUNA          numeric(6)           null,
   DATUM_RACUNA         datetime             null,
   VREDNOST_ROBE        decimal(15,2)        null,
   VREDNOST_USLUGE      decimal(15,2)        null,
   UKUPNO_ROBE_I_USLUGA decimal(15,2)        null,
   UKUPAN_RABAT         decimal(15,2)        null,
   UKUPAN_POREZ         decimal(15,2)        null,
   OZNAKA_VALUTE        varchar(3)           null,
   IZNOS_ZA_UPLATU      decimal(15,2)        null,
   UPLATA_NA_RACUN      varchar(18)          null,
   DATUM_VALUTE         datetime             null,
   constraint PK_FAKTURA primary key nonclustered (ID_FAKTURA)
)
go

/*==============================================================*/
/* Table: FIRMA                                                 */
/*==============================================================*/
create table FIRMA (
   ID_FIRMA             int    IDENTITY(1,1)              not null,
   NAZIV                varchar(255)         null,
   ADRESA               varchar(255)         null,
   PIB                  varchar(11)          null,
   constraint PK_FIRMA primary key nonclustered (ID_FIRMA)
)
go

/*==============================================================*/
/* Table: NALOG_PRENOS                                          */
/*==============================================================*/
create table NALOG_PRENOS (
   ID_NALOG             int   IDENTITY(1,1)               not null,
   ID_PORUKE            varchar(50)          null,
   DUZNIK               varchar(255)         null,
   SVRHA_PLACANJA       varchar(255)         null,
   PRIMALAC             varchar(255)         null,
   DATUM_NALOGA         datetime             null,
   DATUM_VALUTE         datetime             null,
   RACUN_DUZNIKA        varchar(18)          null,
   MODEL_ZADUZENJA      numeric(2)           null,
   POZIV_NA_BROJ_ZADUZENJA varchar(20)          null,
   RACUN_PRIMALAC       varchar(18)          null,
   MODEL_ODOBRENJA      numeric(2)           null,
   POZIV_NA_BROJ_ODOBRENJA numeric(20)          null,
   IZNOS                decimal(15,2)        null,
   OZNAKA_VALUTE        varchar(3)           null,
   HITNO                bit                  null,
   constraint PK_NALOG_PRENOS primary key nonclustered (ID_NALOG)
)
go

/*==============================================================*/
/* Table: RACUN                                                 */
/*==============================================================*/
create table RACUN (
   ID_FIRMA             int                  not null,
   ID_BANKA             int                  not null,
   ID_RACUN             int  IDENTITY(1,1)               not null,
   STANJE                decimal(15,2)        null,
   RACUN                varchar(18)          null
)
go

/*==============================================================*/
/* Table: STAVKA                                                */
/*==============================================================*/
create table STAVKA (
   ID_STAVKA            int  IDENTITY(1,1)                not null,
   ID_FAKTURA           int                  not null,
   REDNI_BROJ           numeric(3)           null,
   NAZIV_ROBE           varchar(120)         null,
   KOLICINA             decimal(10,2)        null,
   JEDINICA_MERE        varchar(6)           null,
   JEDINICNA_CENA       decimal(10,2)        null,
   VREDNOST             decimal(12,2)        null,
   PROCENAT_RABATA      decimal(5,2)         null,
   IZNOS_RABATA         decimal(12,2)        null,
   UKUPAN_POREZ         decimal(15,2)        null,
   constraint PK_STAVKA primary key nonclustered (ID_STAVKA)
)
go

alter table RACUN
   add constraint FK_RACUN_RELATIONS_BANKA foreign key (ID_BANKA)
      references BANKA (ID_BANKA)
go

alter table STAVKA
   add constraint FK_STAVKA_RELATIONS_FAKTURA foreign key (ID_FAKTURA)
      references FAKTURA (ID_FAKTURA)
go

