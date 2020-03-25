create database TTS_ASP_Core
go
use TTS_ASP_Core
go
create table IsLogin
					(account varchar(30) primary key ,
					 Passwork varchar(100) not null,
					 haskPassword nvarchar(10) not null,
					 email varchar(100) not null,
					 deleted bit  not null default 0,
					 decentralization bit not null default 0
					)