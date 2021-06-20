/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2017                    */
/* Created on:     20.06.2021 12:27:09                          */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Data') and o.name = 'FK_DATA_REFERENCE_USERS')
alter table Data
   drop constraint FK_DATA_REFERENCE_USERS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Data') and o.name = 'FK_DATA_REFERENCE_CATEGORI')
alter table Data
   drop constraint FK_DATA_REFERENCE_CATEGORI
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Data') and o.name = 'FK_DATA_REFERENCE_RECEPIEN')
alter table Data
   drop constraint FK_DATA_REFERENCE_RECEPIEN
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Categories')
            and   type = 'U')
   drop table Categories
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Data')
            and   type = 'U')
   drop table Data
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Recepients')
            and   type = 'U')
   drop table Recepients
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Users')
            and   type = 'U')
   drop table Users
go

/*==============================================================*/
/* Table: Categories                                            */
/*==============================================================*/
create table Categories (
   categoryId           int                  identity,
   CategoryName         nvarchar(Max)        not null,
   constraint PK_CATEGORIES primary key (categoryId)
)
go

/*==============================================================*/
/* Table: Data                                                  */
/*==============================================================*/
create table Data (
   idTransaction        int                  identity,
   userId               int                  not null,
   categoryId           int                  not null,
   recepientId          int                  not null,
   CashChange           int                  not null,
   constraint PK_DATA primary key (idTransaction)
)
go

/*==============================================================*/
/* Table: Recepients                                            */
/*==============================================================*/
create table Recepients (
   recepientId          int                  identity,
   Description          nvarchar(Max)        not null,
   constraint PK_RECEPIENTS primary key (recepientId)
)
go

/*==============================================================*/
/* Table: Users                                                 */
/*==============================================================*/
create table Users (
   userId               int                  identity,
   Firstname            nvarchar(Max)        not null,
   Lastname             nvarchar(Max)        not null,
   Cash                 int                  not null,
   constraint PK_USERS primary key (userId)
)
go

alter table Data
   add constraint FK_DATA_REFERENCE_USERS foreign key (userId)
      references Users (userId)
go

alter table Data
   add constraint FK_DATA_REFERENCE_CATEGORI foreign key (categoryId)
      references Categories (categoryId)
go

alter table Data
   add constraint FK_DATA_REFERENCE_RECEPIEN foreign key (recepientId)
      references Recepients (recepientId)
go

