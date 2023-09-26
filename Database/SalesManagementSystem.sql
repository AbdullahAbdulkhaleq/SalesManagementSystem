declare @int int 
EXEC [P_Get_Next_Id] @tableName='Supplier', @NextId= @int output
select @int

create proc GetNextId 
@tableName varchar(30) ,@NextId int output
as
begin
select @NextId =
		CASE @tableName
				WHEN 'Customer' THEN  (select count(CustomerId)+1 from Human.Customer)
				WHEN'Supplier' THEN (select count(SupplierId)+1 from Human.Supplier)
				WHEN'Product' THEN (select count(ProductId)+1 from Inventory.Product)
				WHEN'ProductCategory' THEN (select count(ProductCategoryId)+1 from Inventory.ProductCategory)
				WHEN'Store' THEN (select count(StoreId)+1 from Inventory.Store)
				WHEN'Transactions' THEN (select count(TransactionId)+1 from Inventory.Transactions)
				WHEN'Unit' THEN (select count(UnitId)+1 from Inventory.Unit)
				WHEN'PurchasingDetails' THEN (select count(PurchasingDetailsId)+1 from Purchasing.PurchasingDetails)
				WHEN'PurchasingInvoice' THEN (select count(PurchasingId)+1 from Purchasing.PurchasingInvoice)
				WHEN'SalesDetails' THEN (select count(SalesDetailsId)+1 from Sales.SalesDetails)
				WHEN'SalesInvoice' THEN (select count(SalesId)+1 from Sales.SalesInvoice)
		END	
end

/*
 create proc a 
as 
begin
	begin try 
		
		begin tran 
		select * from a;
		end tran 
	end try 

	begin catch 

	end catch
end
 */

 use SalesManagementSystem
 create proc pLoginInsert 

@id int, @name nvarchar(MAX), @email nvarchar(MAX)
as 
begin

INSERT INTO [dbo].[Login]
           ([id]
           ,[name]
           ,[email])
     VALUES
           (@id,
           @name 
           ,@email )


end

select * from Human.Users
create proc PLogin @UserName nvarchar(50),@UserPassword nvarchar(50)
as
begin
	begin try 
		select * from Human.Users where UserName = @UserName and UserPassword = @UserPassword;
		
	end try 

	begin catch 
		print 'Error';
	end catch
end

PLogin @UserName ='root',@UserPassword='l';

create table Human.User_ (
UserId int identity(1,1) primary key,
UserName nvarchar(50) not null unique,
UserPassword nvarchar(50) not null unique,
UserPermission tinyint default 0
)

create table Inventory.Unit (
UnitId int identity(1,1) primary key ,
UnitCode nvarchar(10) not null unique ,
UnitDesc nvarchar(50) not null 
)
create table Inventory.ProductCategory (
ProductCategoryId int identity(1,1) primary key ,
ProductCategoryName nvarchar(50) not null unique ,
ModifiedDate datetime default SYSDATETIME()
)

create table Human.Customer (
CustomerId int primary key identity(1,1),
CustomerName nvarchar(max) not null,
CustomerEmail nvarchar(30) not null,
CustomerType nvarchar(30) not null default 'Local' ,
customerPhone nvarchar(30) not null
)
create proc P_Customer_Insert
(@CustomerName nvarchar(max),@CustomerEmail nvarchar(30),@CustomerType nvarchar(30),@customerPhone nvarchar(30))
as
begin
INSERT INTO [Human].[Customer]
           (CustomerName
           ,CustomerEmail
           ,CustomerType
           ,customerPhone)
     VALUES
           (@CustomerName
           ,@CustomerEmail
           ,@CustomerType
           ,@customerPhone);
end
--procedure for update customer
create proc P_Customer_Update 
(@CustomerId int,@CustomerName nvarchar(max),@CustomerEmail nvarchar(30),@CustomerType nvarchar(30),@customerPhone nvarchar(30))
as 
begin
	UPDATE Human.Customer
	   SET CustomerName = @CustomerName
		  ,CustomerEmail = @CustomerEmail
		  ,CustomerType = @CustomerType
		  ,customerPhone = @CustomerPhone
	 WHERE CustomerId = @CustomerId;

end



create table Human.Supplier (
SupplierId int primary key identity(1,1),
SupplierName nvarchar(max) not null,
SupplierEmail nvarchar(30) not null,
SupplierType nvarchar(30) not null default 'Local' ,
SupplierPhone nvarchar(30) not null ,
SupplierBrand nvarchar(30)
)

create proc P_Supplier_Insert
(@SupplierName nvarchar(max),@SupplierEmail nvarchar(30),@SupplierType nvarchar(30),@SupplierPhone nvarchar(30),@SupplierBrand nvarchar(30))
as
begin

	Insert into Human.Supplier (SupplierName,SupplierEmail,SupplierType,SupplierPhone,SupplierBrand)
	   values (@SupplierName,@SupplierEmail,@SupplierType,@SupplierPhone,@SupplierBrand);
end
-------
create proc P_Supplier_Delete
(@SupplierId int)
as
begin
	delete from Human.Supplier where SupplierId =@SupplierId;
end
--
create proc P_Supplier_Delete_All
as
begin
	delete from Human.Supplier;
end

create table Inventory.Store (
StoreId int primary key identity(1,1),
StoreName nvarchar(max) not null,
StoreAddress nvarchar(max) not null,
SupplierPhone nvarchar(max) not null ,
)

create table Inventory.Product (
ProductId int primary key identity(1,1),
ProductName nvarchar(max) not null,
ProductNumber nvarchar(max) not null,
ListPrice money not null,
StoreId int foreign key references Inventory.Store(StoreId) ,
UnitId int foreign key references Inventory.Unit (UnitId) ,
ProductCategoryId int foreign key references Inventory.ProductCategory (ProductCategoryId)
)




create table Inventory.Transactions (
TransactionId int primary key identity(1,1),
TransactionType int not null,
TransactionNumber nvarchar(30),
TransactionDate datetime default SYSDATETIME(),
UnitPrice money not null,
QuantityPlus int  not null,
QuantityMinus int not null,
ProductId int foreign key references Inventory.Product(ProductId)
)
create rule rTransactionType
as
in (1,2)

create table Purchasing.PurchasingInvoice (
PurchasingId int identity(1,1) primary key,
PurchasingDate datetime default SYSDATETIME(),
PurchasingTotal money not null,
SupplierId int foreign key references  Human.Supplier(SupplierId),
UserId int foreign key references Human.User_(UserId),
StoreId int foreign key references Inventory.Store(StoreId)
)
create table Purchasing.PurchasingDetails (
PurchasingDetailsId int identity(1,1) primary key,
Quantity int default 1,
UnitPrice money not null ,
ProductId int foreign key references  Inventory.Product(ProductId),
PurchasingId int foreign key references Purchasing.PurchasingInvoice(PurchasingId)
)


create table Sales.SalesInvoice (
SalesId int identity(1,1) primary key,
SalesDate datetime default SYSDATETIME(),
SalesTotal money not null,
CustomerId int foreign key references  Human.Customer(CustomerId),
UserId int foreign key references Human.User_(UserId),
StoreId int foreign key references Inventory.Store(StoreId)
)
create table Sales.SalesDetails (
SalesDetailsId int identity(1,1) primary key,
Quantity int default 1,
UnitPrice money not null ,
availableQuantity int ,
ProductId int foreign key references  Inventory.Product(ProductId),
SalesId int foreign key references Sales.SalesInvoice(SalesId)
)