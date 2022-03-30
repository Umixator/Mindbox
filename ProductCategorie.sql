create table Products (
Id int primary key,
name varchar(75)
)

insert into Products(id, name)
values
(1, 'keyboard'),
(2, 'GPU'),
(3, 'mouse'),
(4, 'freedom')

create table Categories (
Id int primary key,
name varchar(75)
)

insert into Categories(id, name)
values
(1, 'expensive'),
(2, 'medium'),
(3, 'cheap')

create table ProductCategorie (
prodId int foreign key references Products(Id),
categoryId int foreign key references Categories(Id)
)

insert into ProductCategorie (prodId, categoryId)
values
(1, 2),
(2, 1),
(3, 1),
(4, null)

select p.name as "Product_name", c.name as "Category_name" from dbo.Products p
left join dbo.ProductCategorie pc
on p.Id = pc.prodId
left join dbo.Categories c
on c.Id = pc.categoryId