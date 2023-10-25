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

create table PopularLocations
(
LocationID int primary key identity(1,1),
CityName nvarchar(50),
ImageUrl nvarchar(500)
)

create table Testimonials
(
TestimonialID int primary key identity(1,1),
NameSurname nvarchar(50),
Title nvarchar(50),
Comment nvarchar(500),
Status bit,
)

create table SubFeatures
(
SubFeatureID int primary key identity(1,1),
Icon nvarchar(100),
TabTitle nvarchar(100),
MainTitle nvarchar(100),
Description nvarchar(100),
SubTitle nvarchar(100),
)

create table MailSubscribes
(
MailID int primary key identity(1,1),
Email nvarchar(100),
)

create table SocialMedias
(
SocialMediaID int primary key identity(1,1),
Name nvarchar(100),
Icon nvarchar(100),
Url nvarchar(200),
)

create table Contacts
(
ContactID int primary key identity(1,1),
Name nvarchar(100),
Subject nvarchar(100),
Email nvarchar(100),
Message nvarchar(max),
Date date,
)

create table Addresses
(
AddressID int primary key identity(1,1),
Title1 nvarchar(100),
Description nvarchar(200),
Title2 nvarchar(100),
Phone1 nvarchar(50),
Phone2 nvarchar(50),
Email nvarchar(50),
Location nvarchar(500),
)