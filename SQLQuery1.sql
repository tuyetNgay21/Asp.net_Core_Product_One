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
create table Infomation(
						InfomationId varchar(30) primary key foreign key references IsLogin(account),
						IsName nvarchar(50) not null, 
						IsAge int check(IsAge>0 and IsAge<0) not null default 8,
						IsAddress nvarchar(300) not null,
						IsPhone NUMERIC(15,0) not null,
						deleted bit  not null default 0,
)
go
create table IsTheme(
					ThemeId int identity(1,1) primary key,
					Isname nvarchar(50) not null,
					IsTitle nvarchar(50) not null,
					AvatarTheme nvarchar(300) not null )
					go
create table IsSpecies(
					SpeciesId int identity(1,1) primary key,
					Isname nvarchar(50) not null,
					IsTitle nvarchar(30) not null,
					AvatarSpecies nvarchar(300) not null ,
					ThemeId int foreign key references IsTheme(ThemeId)
					)
					go
create table IsPost(
					PostId int identity(1,1) primary key,
					Title nvarchar(100) not null,
					DayInPost date not null default getdate(),
					avataIndex nvarchar(200) not null,
					Content ntext not null,
					ViewPost int default 0,
					SpeciesId int foreign key references IsSpecies(SpeciesId)
)
					go
create table IsIntroduce(
					IntroduceId int identity(1,1) primary key,
					Title nvarchar(100) not null,
					DayInPost date not null default getdate(),
					avataIndex nvarchar(200) not null,
					Content ntext not null,
					ViewPost int default 0
)
