use Blog

--begin transaction 

--drop table Posts
--drop table Authors

create table Authors
(
	Id int not null,
	Name nvarchar(100),
	primary key (id)
)


create table Posts
(
	Id int not null,
	Title nvarchar(50) not null,
	Body nvarchar(max) not null,
	AuthorId int not null,
	Primary Key(Id) ,
	foreign key(AuthorId) references Authors(Id)
)

insert into Authors values (1, 'Anders'), (2,'Mikael')

insert into Posts values 
(1, 'Title 1', 'Woho, waht a body!', 1)
insert into Posts values 
(2, 'Title 2', 'Anoda body!', 1),
(3, 'Title 3', 'Ana de dööörd body!', 2)

select * from Posts
select * from Authors

select count(*) as antal, a.Name from posts p
inner join Authors a on p.AuthorId = a.Id
group by AuthorId

select p.Title, p.Body, a.Name from Posts p
inner join Authors a on p.AuthorId = a.Id

select p.Title, p.Body, a.Name from Posts p
inner join Authors a on p.AuthorId = a.Id
where a.Id = 1

delete from posts where id = 2
 
--rollback transaction 