create proc GetBrands
as 
begin
select * from production.brands
end
go

create proc GetCategories
as
begin
select * from production.categories
end
go

create proc GetProducts
as
begin
select P.product_id, P.product_name, B.brand_name, C.category_name, P.model_year, P.list_price from production.products P
inner join production.brands B on P.brand_id = B.brand_id
inner join production.categories C on P.category_id = C.category_id
end
go

create proc GetProductById
(
@id int
)
as
begin
select * from production.products where product_id = @id
end
go

create proc InsertProduct 
(
@product_name nvarchar(255),
@brand_id int,
@category_id int,
@model_year int,
@list_price decimal(10,2)
)
as
begin
insert into production.products values (@product_name,@brand_id,@category_id,@model_year,@list_price)
end
go

create proc UpdateProduct 
(
@product_id int,
@product_name nvarchar(255),
@brand_id int,
@category_id int,
@model_year int,
@list_price decimal(10,2)
)
as
begin
update production.products set 
product_name = @product_name, 
brand_id = @brand_id, 
category_id = @category_id, 
model_year = @model_year, 
list_price = @list_price where product_id = @product_id
end
go

create proc DeleteProductById
(
@id int
)
as
begin
delete production.products where product_id = @id
end
go