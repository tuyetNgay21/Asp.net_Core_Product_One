create database TTS_ASP_Core
go
use TTS_ASP_Core
go
create table IsLogin
					(account varchar(50) primary key ,
					 Passwork varchar(100) not null,
					 haskPassword nvarchar(10) not null,
					 email varchar(100) not null,
					 deleted bit  not null default 0,
					 decentralization bit not null default 0
					)
					go

create table Infomation(
						InfomationId varchar(50) primary key foreign key references IsLogin(account),
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
					deleted bit  not null default 0,
					AvatarTheme nvarchar(300) not null )
					go
create table IsSpecies(
					SpeciesId int identity(1,1) primary key,
					Isname nvarchar(50) not null,
					IsTitle nvarchar(50) not null,
					AvatarSpecies nvarchar(300) not null ,
					deleted bit  not null default 0,
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
					deleted bit  not null default 0,
					SpeciesId int foreign key references IsSpecies(SpeciesId)
)
go
create table IsVideo(
				    VideoId int identity(1,1) primary key,
					Title nvarchar(100) not null,
					DayInPost date not null default getdate(),
					VideoIndex nvarchar(200) not null,
					Content ntext not null,
					ViewPost int default 0,
					deleted bit  not null default 0,
					SpeciesId int foreign key references IsSpecies(SpeciesId)
)
--admin user
					go
create table IsIntroduce(
					IntroduceId int identity(1,1) primary key,
					Title nvarchar(100) not null,
					DayInPost date not null default getdate(),
					avataIndex nvarchar(200) not null,
					Content ntext not null,
					ViewPost int default 0,
					deleted bit  not null default 0
)
go
create table IsNavbar(
						NavbarId int identity(1,1) primary key ,
						image1 nvarchar(100) not null,
						linkImage1 nvarchar(100) not null,
						image2 nvarchar(100),
						linkImage2 nvarchar(100),
						image3 nvarchar(100),
						linkImage3 nvarchar(100),
						image4 nvarchar(100),
						linkImage4 nvarchar(100),
						image5 nvarchar(100),
						linkImage5 nvarchar(100),
						image6 nvarchar(100),
						linkImage6 nvarchar(100),
						image7 nvarchar(100),
						linkImage7 nvarchar(100),
						image8 nvarchar(100),
						linkImage8 nvarchar(100),
						image9 nvarchar(100),
						linkImage9 nvarchar(100),
						image10 nvarchar(100),
						linkImage10 nvarchar(100),
						deleted bit  not null default 0,
						dateUpdate date not null default getdate()
)
go
create table MenuTop1(
					MenuTopId1 int identity(1,1) primary key ,
					menu1 nvarchar(10) not null,				
					linkMenu1 nvarchar(100) not null,
					menu2 nvarchar(10) not null,
					linkMenu2 nvarchar(100) not null,
					menu3 nvarchar(10) not null,
					linkMenu3 nvarchar(100) not null,
					menu4 nvarchar(10) not null,
					linkMenu4 nvarchar(100) not null,
					menu5 nvarchar(10) not null,
					linkMenu5 nvarchar(100) not null,
					menu6 nvarchar(10) not null,
					linkMenu6 nvarchar(100) not null,
					menu7 nvarchar(10) not null,
					linkMenu7 nvarchar(100) not null,
					menu8 nvarchar(10) not null,
					linkMenu8 nvarchar(100) not null,
					deleted bit  not null default 0,
					dateUpdate date not null default getdate()
					)
					go
create table MenuTop2(
					MenuTopId2 int identity(1,1) primary key ,
					Section1 nvarchar(10) not null,
					linkMenu1 nvarchar(100) not null,
					Section2 nvarchar(10) not null,
					linkMenu2 nvarchar(100) not null,
					Section3 nvarchar(10) not null,
					linkMenu3 nvarchar(100) not null,
					Section4 nvarchar(10) not null,
					linkMenu4 nvarchar(100) not null,
					Section5 nvarchar(10) not null,
					linkMenu5 nvarchar(100) not null,
					Section6 nvarchar(10) not null,
					linkMenu6 nvarchar(100) not null,
					Section7 nvarchar(10) not null,
					linkMenu7 nvarchar(100) not null,
					deleted bit  not null default 0,
					dateUpdate date not null default getdate()
					)
					go

create table MenuFooter(
					MenuFooterid int identity(1,1) primary key ,
					TitleSection nvarchar(50)  not null,
					Section1 nvarchar(10) not null,
					linkMenu1 nvarchar(100) not null,
					Section2 nvarchar(10) not null,
					linkMenu2 nvarchar(100) not null,
					Section3 nvarchar(10) not null,
					linkMenu3 nvarchar(100) not null,
					Section4 nvarchar(10) not null,
					linkMenu4 nvarchar(100) not null,
					Section5 nvarchar(10) not null,
					linkMenu5 nvarchar(100) not null,
					Section6 nvarchar(10) not null,
					linkMenu6 nvarchar(100) not null,
					Section7 nvarchar(10) not null,
					linkMenu7 nvarchar(100) not null,
					deleted bit  not null default 0,
					dateUpdate date not null default getdate()
					)
					go
create table IsAdmin(
					AdminId int identity(1,1) primary key ,
					logo nvarchar(100) not null, 
					MenuFooterid1 int foreign key references MenuFooter(MenuFooterid),
					MenuFooterid2 int foreign key references MenuFooter(MenuFooterid),
					MenuFooterid3 int foreign key references MenuFooter(MenuFooterid),
					MenuTopId2 int foreign key references MenuTop2(MenuTopId2),
					MenuTopId1 int foreign key references MenuTop1(MenuTopId1),
					)
