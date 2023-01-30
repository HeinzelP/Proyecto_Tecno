Create Database ga1heinzel
Use ga1heinzel

Create Table crud(
	nombre varchar (20),
	id varchar (20),
	apellido varchar (20),
	edad varchar(20),
);
Insert into crud values ('Luis','2','Ramirez','18')
Insert into crud values ('Heinzel','3','Perez','17')
Select*from crud

Create Table logins(
	nombre varchar(20),
	contra varchar(20),
);

Insert into logins values('adAlexander','am123')
Insert into logins values('seMaria','scqwe')
Insert into logins values('clOscar','cl321')
Select*from logins
