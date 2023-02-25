use Library01
create table Authors
(
	Id int not null identity(1,1) primary key,
	FirstName varchar(20) not null,
	LastName varchar(20) not null
)
create table Books
(
	Id int not null identity(1,1) primary key,
	AuthorId int not null,
	foreign key (AuthorId) references Authors (id),
	Title varchar (100) not null,
	Price int,
	Pages int
)