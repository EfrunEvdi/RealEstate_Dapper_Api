create database DbDapperRealEstate

use DbDapperRealEstate

create table Category
(
CategoryID int primary key identity (1,1),
CategoryName nvarchar(50),
CategoryStatus bit
)

create table Product
(
ProductID int primary key identity (1,1),
Title nvarchar(100),
Price decimal(18,2),
CoverImage nvarchar(250),
City nvarchar(100),
District nvarchar(100),
Address nvarchar(500),
Description nvarchar(max),
ProductCategory int,
)

create table ProductDetails
(
ProductDetailID int primary key identity (1,1),
Size int,
BedRoomCount tinyint,
BathCount tinyint,
RoomCount tinyint,
GarageSize tinyint,
BuildYear char(4),
Price decimal(18,2),
Location nvarchar(500),
VideoUrl nvarchar(500),
ProductID int,
)

create table Client
(
ClientID int primary key identity (1,1),
Name nvarchar(100),
Title nvarchar(100),
Comment nvarchar(2000)
)

create table Employee
(
EmployeeID int primary key identity (1,1),
Name nvarchar(100),
Title nvarchar(100),
Mail Nvarchar(100),
PhoneNumber nvarchar(100),
ImageUrl nvarchar(100),
Status  bit
)


create Table WhoWeAreDetail
(
WhoWeAreDetailID int identity(1,1) primary key,
Title Nvarchar(100),
Subtitle Nvarchar(100),
Description1 Nvarchar(500),
Description2 Nvarchar(500),
)

create Table Services
(
ServiceID int identity(1,1) primary key,
Name Nvarchar(100),
Status bit
)

Create table BottomGrid
(
BottomGridID int identity(1,1) primary key,
Icon nvarchar(100),
Title nvarchar(100),
Description nvarchar(250),
)