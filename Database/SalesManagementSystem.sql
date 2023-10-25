use master
go
drop database if exists SalesManagementSystem;
go
-------------------------------------------create database-----------------------------------------------
create database SalesManagementSystem
on primary 
(Name='primary' ,filename='E:\DB\SaleManagementSystem\primary.mdf' , SIZE = 8MB ,filegrowth= 10%),
Filegroup [Main]
(Name='Main' ,filename='E:\DB\SaleManagementSystem\Main.ndf' ,size =50MB ,filegrowth=10%),
FileGroup Human
(Name='Human_M' ,filename='E:\DB\SaleManagementSystem\Human_M.ndf' ,size =8MB ,filegrowth=102404KB),
(Name='Human_S' ,filename='E:\DB\SaleManagementSystem\Human_S.ndf' ,size =8MB ,filegrowth=102404KB),
FileGroup Inventory
(Name='Inventory_M' ,filename='E:\DB\SaleManagementSystem\Inventory_M.ndf' ,size =8MB ,filegrowth=102404KB),
(Name='Inventory_S' ,filename='E:\DB\SaleManagementSystem\Inventory_S.ndf' ,size =8MB ,filegrowth=102404KB),
FileGroup Purchasing
(Name='Purchasing_M' ,filename='E:\DB\SaleManagementSystem\Purchasing_M.ndf' ,size =8MB ,filegrowth=102404KB),
(Name='Purchasing_S' ,filename='E:\DB\SaleManagementSystem\Purchasing_S.ndf' ,size =8MB ,filegrowth=102404KB),
FileGroup Sales
(Name='Sales_M' ,filename='E:\DB\SaleManagementSystem\Sales_M.ndf' ,size =8MB ,filegrowth=102404KB),
(Name='Sales_S' ,filename='E:\DB\SaleManagementSystem\Sales_S.ndf' ,size =8MB ,filegrowth=102404KB)
LOG ON 
(Name='Log' ,filename='E:\DB\SaleManagementSystem\Log\Log.ldf' ,SIZE =15MB ,filegrowth=5MB)
go

alter database SalesManagementSystem modify filegroup Main default
-------------------------------------------End create database-----------------------------------------------
use SalesManagementSystem
go
------------------------------------------------------------------------------------------------------
-------------------------------------------create Login and User -----------------------------------------------

-------------------------------------------End create Login and User -----------------------------------------------


-------------------------------------------create schema-----------------------------------------------
CREATE schema Human;
GO
create schema Inventory;
go
create schema Purchasing;
go
create schema Sales;
go

-------------------------------------------End create schema-----------------------------------------------

-------------------------------------------create Rule-----------------------------------------------

-------------------------------------------End create Rule-----------------------------------------------

-------------------------------------------create DataType-----------------------------------------------
create TYPE Id
from int
not null
go

create TYPE Name_
from nvarchar(max)
not null
go

create TYPE SName
from nvarchar(30)
not null
go

create TYPE Password_
from nvarchar(30)
not null
go

create TYPE Email
from nvarchar(30)
not null
go

create TYPE Phone
from nvarchar(20)
not null
go

create TYPE Description_
from nvarchar(max)
not null
go

create TYPE Brand
from nvarchar(20)
not null
go

create TYPE Address_
from nvarchar(100)
not null
go

create TYPE Quantity
from int
not null
go

create TYPE Table_
from nvarchar(30)
not null
go
-------------------------------------------End create DataType-----------------------------------------------



-------------------------------------------create Table-----------------------------------------------
create table Log_ 
(
Name_ Name_,
Date_ Datetime2
)
go

create table Human.Department (
DepartmentId Id identity(1,1) primary key,
DepartmentName SName unique
)on Human
GO


create table Human.User_ (
UserId Id identity(1,1) primary key,
UserName SName unique,
UserPassword Password_ unique,
UserStatus tinyint default 0 check (UserStatus in(1,0)),
DepartmentId Id foreign key references Human.Department(DepartmentId),
) on Human
go
create table Human.RecoveryPassword (
RecoveryId Id identity(1,1) primary key,
WhatsYourFavoriteAnimal Name_,
WhatsIsayourBestCity Name_,
WhatsYourFavoriteHobby Name_,
UserId Id foreign key references Human.User_(UserId)
)on Human
go
create table Inventory.Unit (
UnitId Id identity(1,1) primary key ,
UnitCode nvarchar(30) not null unique ,
UnitDesc description_ 
) on Inventory
go

create table Inventory.ProductCategory (
ProductCategoryId Id identity(1,1) primary key ,
ProductCategoryName SName unique ,
ModifiedDate datetime default SYSDATETIME()
)on Inventory
go

create table Human.Customer (
CustomerId Id primary key identity(1,1),
CustomerName Name_,
CustomerEmail Email,
CustomerType SName not null default N'محلي' ,
customerPhone Phone 
)on Human
go

create table Human.Supplier (
SupplierId Id primary key identity(1,1),
SupplierName Name_,
SupplierEmail EmaiL ,
SupplierType SName not null default N'محلي' ,
SupplierPhone Phone ,
SupplierBrand Brand
)on Human
go


create table Inventory.Store (
StoreId Id primary key identity(1,1),
StoreName Name_,
StoreAddress Address_,
StorePhone Phone ,
)on Inventory
go

create table Inventory.Product (
ProductId Id primary key identity(1,1),
ProductName SName unique,
LastPrice money not null,
StoreId Id foreign key references Inventory.Store(StoreId) ,
UnitId Id foreign key references Inventory.Unit (UnitId) ,
ProductCategoryId Id foreign key references Inventory.ProductCategory (ProductCategoryId)
)on Inventory
go


create table Inventory.Transactions (
TransactionId Id primary key identity(1,1),
TransactionType nvarchar(10) not null check (TransactionType in (N'مبيعات',N'مشتريات')),
TransactionNumber int not null,
TransactionDate datetime ,
UnitPrice money not null,
QuantityPlus Quantity,
QuantityMinus Quantity,
ProductId Id foreign key references Inventory.Product(ProductId)
)on Inventory
go

create table Purchasing.PurchasingInvoice (
PurchasingId Id identity(1,1) primary key,
PurchasingDate datetime default SYSDATETIME(),
PurchasingTotal money not null,
SupplierId Id foreign key references  Human.Supplier(SupplierId),
UserId Id foreign key references Human.User_(UserId),
StoreId Id foreign key references Inventory.Store(StoreId)
)on Purchasing
go

create table Purchasing.PurchasingDetails (
PurchasingDetailsId Id identity(1,1) primary key,
Quantity Quantity default 1,
UnitPrice money not null ,
ProductId Id foreign key references  Inventory.Product(ProductId),
PurchasingId Id foreign key references Purchasing.PurchasingInvoice(PurchasingId)
)on Purchasing
go

create table Sales.SalesInvoice (
SalesId Id identity(1,1) primary key,
SalesDate datetime default SYSDATETIME(),
SalesTotal money not null,
CustomerId Id foreign key references  Human.Customer(CustomerId),
UserId Id foreign key references Human.User_(UserId),
StoreId Id foreign key references Inventory.Store(StoreId)
)on Sales
go

create table Sales.SalesDetails (
SalesDetailsId Id identity(1,1) primary key,
Quantity Quantity default 1,
UnitPrice money not null ,
ProductId Id foreign key references  Inventory.Product(ProductId),
SalesId Id foreign key references Sales.SalesInvoice(SalesId)
)on Sales
go
-------------------------------------------End create Table-----------------------------------------------
---------------------------------------------------------------------------------------------------------------

----------------------------------------index---------------------------------------------------------
create clustered index CILog_ on dbo.Log_(Date_)
go
create nonclustered index NCIPurchasingDate on Purchasing.PurchasingInvoice(PurchasingDate)
go
create nonclustered index NCISalesDate on Sales.SalesInvoice(SalesDate)
go
alter index CILog_ on dbo.Log_ rebuild with (data_compression = page)

go
exec sp_helpindex 'dbo.Log_' --TableName 
go

select  i.name AS IndesName,
        o.name AS TableName,
		P.partition_Number AS partitionNumber,
		f.name AS filegroup_Name
		from sys.indexes i
		inner join sys.objects o on
		i.object_id=o.object_id
		inner join sys.partitions p on
		i.object_id=p.object_id AND 
		i.index_id=p.index_id
		inner join sys.allocation_units au  on
		p.partition_id =au.container_id
		inner join sys.filegroups f on
		au.data_space_id=f.data_space_id where 
		o.name='Log' AND i.name='CILog_';
go
----------------------------------------End index---------------------------------------------------------

-------------------------------------------------------------------------------------------------
--ALTER  database SalesManagementSystem set recovery simple
--go

--SET TRANSACTION ISOLATION LEVEL READ COMMITTED;
--go
--BEGIN TRANSACTION;
--SELECT * FROM Sales.SalesOrderDetail WHERE SalesOrderID = 43659;
--COMMIT;

--go
----b--
--SET TRANSACTION ISOLATION LEVEL REPEATABLE READ;
--BEGIN TRANSACTION;
--SELECT * FROM Sales.SalesOrderDetail WHERE SalesOrderID = 43659;
--COMMIT;

--go
----c--
--SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;
--BEGIN TRANSACTION;
--SELECT * FROM Sales.SalesOrderDetail WHERE SalesOrderID = 43659;
--COMMIT;

--go
----6.1.a--

BACKUP DATABASE SalesManagementSystem
TO DISK = 'E:\DB\backup\backup1.bak'
WITH FORMAT, MEDIANAME = 'E_SQLServerBackups',
NAME = 'Full Backup of SalesManagementSystem';
go
--6.1.b--
BACKUP DATABASE SalesManagementSystem
TO DISK = 'E:\DB\backup\backup2.bak'
WITH DIFFERENTIAL, MEDIANAME = 'E_SQLServerBackups',
NAME = 'Differential Backup of SalesManagementSystem';
go
--6.1.c--
BACKUP LOG SalesManagementSystem
TO DISK = 'E:\DB\backup\backup3.bak'
WITH FORMAT, MEDIANAME = 'E_SQLServerBackups',
NAME = 'Log Backup of SalesManagementSystem';
go
--6.1.d--
BACKUP DATABASE SalesManagementSystem 
TO DISK = 'E:\DB\backup\backup4.bak' 
WITH COMPRESSION, FORMAT;
go
---------------------------------------------------------------------------------------------------------------

-------------------------------------------create View-----------------------------------------------
create view Customer
as
Select CustomerId as Id,  CustomerName as Name ,CustomerType as Type ,CustomerEmail as Email ,CustomerPhone as Phone from Human.Customer
GO
create view Supplier
as
Select SupplierId as Id,  SupplierName as Name ,SupplierType as Type ,SupplierEmail as Email ,SupplierPhone as Phone,SupplierBrand as Brand from [Human].[Supplier]
GO
create view User_
as
Select u.UserId as Id,  u.UserName as Name ,u.UserPassword as Password , case u.UserStatus when 1 then N'نشط' Else N'خامل'end as Status ,d.DepartmentName as Department from [Human].[User_] u , [Human].[Department] d
where u.DepartmentId =d.DepartmentId 
GO
create view Product
as
Select  p.ProductId as Id,  
		p.ProductName as Name ,
		p.LastPrice as Price  , 
		s.StoreName as Store ,
		u.UnitCode as Unit ,
		c.ProductCategoryName as Category 
from [Inventory].[Product] p, [Inventory].[ProductCategory] c, [Inventory].[Store] s ,[Inventory].[Unit] u
where p.StoreId =s.StoreId and p.UnitId =  u.UnitId and p.ProductCategoryId = c.ProductCategoryId
GO
create view Department
as
Select DepartmentId as Id,  DepartmentName as Name  from [Human].[Department]
GO
create view ProductCategory
as
Select ProductCategoryId as Id,  ProductCategoryName as Name,ModifiedDate as Date  from [Inventory].[ProductCategory]
GO

create view Store
as
Select StoreId as Id,  StoreName as Name,StoreAddress Address,StorePhone as Phone  from [Inventory].[Store]
GO

create view Unit
as
Select UnitId as Id,  UnitCode as Code,UnitDesc as Description  from [Inventory].[Unit]
GO

select * from Unit
GO
-------------------------------------------End create View-------------------------------------------


-------------------------------------------Insert Data procedure-----------------------------------------------
insert into [Human].[Customer] (CustomerName,CustomerEmail,customerPhone)
Select distinct FullName, cast(EmailAddress as nvarchar(20)) , PhoneNumber 
from   WideWorldImporters.[Application].People 
where EmailAddress is not null and PhoneNumber is not null
go
insert into Human.Supplier (SupplierName,SupplierEmail,SupplierPhone,SupplierBrand)
Select distinct e.SupplierName,cast(p.EmailAddress as nvarchar(20)) , e.PhoneNumber,PreferredName
from   WideWorldImporters.[Purchasing].[Suppliers] e,
 WideWorldImporters.[Application].People p
 where p.EmailAddress is not null
go
Select * into Invoices from WideWorldImporters.[Sales].[Invoices]
go
Select * into Orders from WideWorldImporters.[Sales].[Orders]
go
-------------------------------------------End Insert Data procedure-----------------------------------------------


-------------------------------------------create procedure-----------------------------------------------
CREATE PROCEDURE GetFileAndFilegroupInfo
    @DatabaseName NVARCHAR(128)
AS
BEGIN
    
    SELECT 
        f.name AS [File Name],
        fg.name AS [Filegroup Name],
        f.size/128.0 AS [File Size (MB)],
        f.physical_name AS [Physical Path]
    FROM sys.master_files f
    INNER JOIN sys.filegroups fg ON f.data_space_id = fg.data_space_id
    WHERE DB_NAME(database_id) = @DatabaseName
    ORDER BY fg.name, f.name;
END
go 
EXEC GetFileAndFilegroupInfo @DatabaseName = 'SalesManagementSystem'
go
create procedure [dbo].[PLogin]
(@UserName nvarchar(50), @UserPassword nvarchar(50) ,@LoginStatus int out)
as
begin

	begin try 
		if exists(select * from Human.User_ where UserName = @UserName and UserPassword = @UserPassword)
		begin
			 declare @UserStatus int;
			 select @UserStatus = UserStatus from Human.User_  where UserName = @UserName and UserPassword = @UserPassword;
				if @UserStatus != 0 
					set @LoginStatus = (select DepartmentId from Human.User_ where UserName = @UserName and UserPassword = @UserPassword);
				else
					set @LoginStatus = 5;
		END
		ELSE 

			set @LoginStatus = 404;	

	end try 
	begin catch 
		set @LoginStatus = 0;
	end catch

end
GO

CREATE procedure [dbo].[P_Get_Next_Id] 
@tableName Nvarchar(30) ,@NextId int output
as
begin
	declare @Id int ;

	select  @Id   =
			CASE @tableName 
				
					WHEN 'Customer' THEN  (select max(CustomerId)+1 from Human.Customer)
					WHEN'Supplier' THEN (select max(SupplierId)+1 from Human.Supplier)
					WHEN'Product' THEN (select max(ProductId)+1 from Inventory.Product)
					WHEN'ProductCategory' THEN (select max(ProductCategoryId)+1 from Inventory.ProductCategory)
					WHEN'Store' THEN (select max(StoreId)+1 from Inventory.Store)
					WHEN'Transactions' THEN (select max(TransactionId)+1 from Inventory.Transactions)
					WHEN'Unit' THEN (select max(UnitId)+1 from Inventory.Unit)
					WHEN'PurchasingDetails' THEN (select max(PurchasingDetailsId)+1 from Purchasing.PurchasingDetails)
					WHEN'PurchasingInvoice' THEN (select max(PurchasingId)+1 from Purchasing.PurchasingInvoice)
					WHEN'SalesDetails' THEN (select max(SalesDetailsId)+1 from Sales.SalesDetails)
					WHEN'SalesInvoice' THEN (select max(SalesId)+1 from Sales.SalesInvoice)
			END
	------check if the id is onec ------
	select @NextId = 
					case when 
					      @Id  is null then 1 
						  else @Id 
					end
	
end
GO




declare @int Id 
EXEC [P_Get_Next_Id] @tableName='Supplier', @NextId= @int output
select @int
go


create procedure [dbo].[P_Insert]
(
		 @TableName Table_,
		 @Name Name_ ='NOT INSERTED',
		 @Email Email ='NOT INSERTED',
		 @Type nvarchar(max) ='NOT INSERTED',
		 @Phone Phone ='NOT INSERTED',
		 @Address Address_ ='NOT INSERTED',
		 @SupplierBrand Brand ='NOT INSERTED',
		 @LastPrice money =0,
		 @StoreId Id = 1,
		 @PurchasingDetailsId Id =1,
		 @ProductId Id =1 ,
		 @ProductCategoryId Id =1 ,
		 @UserId Id =1,
		 @CustomerId Id =1,
		 @SupplierId Id =1 ,
		 @SalesId Id =1 ,
		 @PurchasingId Id =1 ,
		 @SalesDetailsId Id =1,
		 @UnitId Id  =1,
		 @UnitCode nvarchar(max) ='NOT INSERTED',
		 @UnitDesc Description_ ='NOT INSERTED' ,
		 @UnitPrice money =0,
		 @QuantityMinus Quantity = 0,
		 @QuantityPlus Quantity =0,
		 @Quantity Quantity =1 ,
		 @Total money =0 ,
		 @Sccessfully bit output
 )
as
begin

	if(@TableName like 'Customer') 
	begin
		begin try 
			begin transaction
				INSERT INTO [Human].[Customer]
				   (CustomerName ,CustomerEmail ,CustomerType ,customerPhone) 
				   VALUES (@Name,@Email ,@Type,@Phone);
				   set @Sccessfully =1;
			commit transaction
		end try

		begin catch 
			rollback transaction
			   set @Sccessfully =2;
		end catch
	end

	else if(@TableName  like 'Supplier')
	begin
		begin try 
			begin transaction
				INSERT INTO Human.Supplier
				   (SupplierName ,SupplierEmail ,SupplierType ,SupplierPhone,SupplierBrand) 
				   VALUES (@Name,@Email ,@Type,@Phone,@SupplierBrand);
				   set @Sccessfully =1;
			commit transaction
		end try

		begin catch 
			rollback transaction
			   set @Sccessfully =2;
		end catch
	end

	else if(@TableName  like 'Product')
	begin
		begin try 
			begin transaction
				INSERT INTO Inventory.Product 
					(ProductName,LastPrice,StoreId,UnitId,ProductCategoryId)
					values (@Name,@LastPrice,@StoreId,@UnitId,@ProductCategoryId);
				   set @Sccessfully =1;
			commit transaction
		end try

		begin catch 
			rollback transaction
			   set @Sccessfully =2;
		end catch
	end

	else if(@TableName  like 'ProductCategory')
	begin
		begin try 
			begin transaction
				INSERT INTO Inventory.ProductCategory 
					(ProductCategoryName) values (@Name);
				   set @Sccessfully =1;
			commit transaction
		end try

		begin catch 
			rollback transaction
			   set @Sccessfully =2;
		end catch			
	end

	else if(@TableName  like 'Store')
	begin
		begin try 
			begin transaction
				INSERT INTO Inventory.Store 
					(StoreName,StoreAddress,StorePhone)
					values (@Name ,@Address,@Phone);
				   set @Sccessfully =1;
			commit transaction
		end try

		begin catch 
			rollback transaction
			   set @Sccessfully =2;
		end catch
	end

	else if(@TableName  like 'Unit')
	begin
		begin try 
			begin transaction
				INSERT INTO Inventory.Unit 
					(UnitCode,UnitDesc)
					values (@UnitCode,@UnitDesc);
				   set @Sccessfully =1;
			commit transaction
		end try

		begin catch 
			rollback transaction
			   set @Sccessfully =2;
		end catch
	end

	else if(@TableName  like 'PurchasingInvoice')
	begin
		begin try 
			begin transaction
				INSERT INTO Purchasing.PurchasingInvoice 
					(PurchasingTotal,SupplierId,UserId,StoreId)
					values (@Total,@SupplierId,@UserId,@StoreId);
				   set @Sccessfully =1;
			commit transaction
		end try

		begin catch 
			rollback transaction
			   set @Sccessfully =2;
		end catch
	end

	else if(@TableName  like 'PurchasingDetails')
	begin
		begin try 
			rollback transaction
				INSERT INTO Purchasing.PurchasingDetails
					(Quantity,UnitPrice,ProductId,PurchasingId)
					values (@Quantity,@UnitPrice,@ProductId,@PurchasingId);
				INSERT INTO Inventory.Transactions 
						(TransactionType,TransactionNumber,TransactionDate,UnitPrice,QuantityPlus,QuantityMinus,ProductId)
						values (N'مشتريات',@PurchasingId,(SELECT PurchasingDate FROM Purchasing.PurchasingInvoice WHERE PurchasingId= @PurchasingId),@UnitPrice,@QuantityPlus,@QuantityMinus,@ProductId); 
			rollback transaction
			set @Sccessfully =1;
		end try

		begin catch 
			rollback transaction
			   set @Sccessfully =2;
		end catch
	end

	else if(@TableName  like 'SalesInvoice')
	begin
		begin try 
			rollback transaction
				INSERT INTO Sales.SalesInvoice
					(SalesTotal,CustomerId,UserId,StoreId)
					values (@Total,@CustomerId,@UserId,@StoreId);
			rollback transaction
			   set @Sccessfully =1;
		end try

		begin catch 
			rollback transaction
			   set @Sccessfully =2;
		end catch
	end
	
	else if(@TableName  like 'SalesDetails')
	begin
		begin try 
		--begin transaction
			begin transaction				
				if((select SUM(QuantityPlus-QuantityMinus) from Inventory.Transactions where ProductId =@ProductId)>@Quantity)
				begin 
					INSERT INTO Sales.SalesDetails 
						(Quantity,UnitPrice,ProductId,SalesId)
						values (@Quantity,@UnitPrice,@ProductId,@SalesId);
					INSERT INTO Inventory.Transactions 
						(TransactionType,TransactionNumber,TransactionDate,UnitPrice,QuantityPlus,QuantityMinus,ProductId)
						values (N'مبيعات',@SalesId,(SELECT SalesDate FROM sales.SalesInvoice WHERE SalesId= @SalesId),@UnitPrice,@QuantityPlus,@QuantityMinus,@ProductId);
					   set @Sccessfully =1;
				end
				else 
				begin
					ROLLBACK TRANSACTION
					set @Sccessfully =3;
				end
			COMMIT TRANSACTION
		--End transaction
		end try

		begin catch 
			ROLLBACK TRANSACTION
			   set @Sccessfully =2;
		end catch

	end

end
GO

create procedure [dbo].[P_Delete] 
(
	@TableName Table_,
	@Id Id ,
	@Sccessfully bit output
)
as
begin

	 if(@TableName  like 'Customer')
	begin
		begin try 
			begin Transaction
				if exists (select * from Human.Customer where CustomerId =@Id)
				begin
					delete from Human.Customer where CustomerId =@Id;
					set @Sccessfully =1;
				end
				else
					set @Sccessfully =404;
			commit Transaction
		end try 

		begin catch 
			rollback Transaction
				set @Sccessfully =5;
		end catch
	end
	
	else if(@TableName  like 'Supplier')

	begin
		begin try 
			begin Transaction
				if exists (select * from Human.Supplier where SupplierId =@Id)
				begin
					delete from Human.Supplier where SupplierId =@Id;
					set @Sccessfully =1;
				end
				else
					set @Sccessfully =404;
			commit Transaction
		end try 

		begin catch 
			rollback Transaction
				set @Sccessfully =5;
		end catch
	end
	
	else if(@TableName  like 'Product')

	begin
		begin try 
			begin Transaction
				if exists (select * from Inventory.Product where ProductId =@Id)
				begin
					delete from Inventory.Product where ProductId =@Id;
					set @Sccessfully =1;
				end
				else
					set @Sccessfully =404;
			commit Transaction
		end try 

		begin catch 
			rollback Transaction
				set @Sccessfully =5;
		end catch
	end
	
	else if(@TableName  like 'ProductCategory')
	begin
		begin try 
			begin Transaction
				if exists (select * from Inventory.ProductCategory where ProductCategoryId =@Id)
				begin
					delete from Inventory.ProductCategory where ProductCategoryId =@Id;
					set @Sccessfully =1;
				end
				else
					set @Sccessfully =404;
			commit Transaction
		end try 

		begin catch 
			rollback Transaction
				set @Sccessfully =5;
		end catch
	end
	
	else if(@TableName  like 'Store')
	begin
		begin try 
			begin Transaction
				if exists (select * from Inventory.Store where StoreId =@Id)
				begin
					delete from Inventory.Store where StoreId =@Id;
					set @Sccessfully =1;
				end
				else
					set @Sccessfully =404;
			commit Transaction
		end try 

		begin catch 
			rollback Transaction
				set @Sccessfully =5;
		end catch
	end
	
	else if(@TableName  like 'Unit')
	begin
		begin try 
			begin Transaction
				if exists (select * from Inventory.Unit where UnitId =@Id)
				begin
					delete from Inventory.Unit where UnitId =@Id;
					set @Sccessfully =1;
				end
				else
					set @Sccessfully =404;
			commit Transaction
		end try 

		begin catch 
			rollback Transaction
				set @Sccessfully =5;
		end catch
	end
	
	else if(@TableName  like 'PurchasingInvoice')
	begin
		begin try 
			begin Transaction
				if exists (select * from Purchasing.PurchasingInvoice where PurchasingId =@Id)
				begin
					delete from Purchasing.PurchasingInvoice where PurchasingId =@Id;
					set @Sccessfully =1;
				end
				else
					set @Sccessfully =404;
			commit Transaction
		end try 

		begin catch 
			rollback Transaction
				set @Sccessfully =5;
		end catch
	end
	
	else if(@TableName  like 'PurchasingDetails')
	begin
		begin try 
			begin Transaction
				if exists (select * from Purchasing.PurchasingDetails where PurchasingDetailsId =@Id)
				begin
					delete from Purchasing.PurchasingDetails where PurchasingDetailsId =@Id;
					set @Sccessfully =1;
				end
				else
					set @Sccessfully =404;
			commit Transaction
		end try 

		begin catch 
			rollback Transaction
				set @Sccessfully =5;
		end catch
	end
	
	else if(@TableName  like 'SalesInvoice')
	begin
		begin try 
			begin Transaction
				if exists (select * from Sales.SalesInvoice where SalesId =@Id)
				begin
					delete from Sales.SalesInvoice where SalesId =@Id;
					set @Sccessfully =1;
				end
				else
					set @Sccessfully =404;
			commit Transaction
		end try 

		begin catch 
			rollback Transaction
				set @Sccessfully =5;
		end catch
	end
	
	else if(@TableName  like 'SalesDetails')
	begin
		begin try 
			begin Transaction
				if exists (select * from Sales.SalesDetails where SalesDetailsId =@Id)
				begin
					delete from Sales.SalesDetails where SalesDetailsId =@Id;
					set @Sccessfully =1;
				end
				else
					set @Sccessfully =404;
			commit Transaction
		end try 

		begin catch 
			rollback Transaction
				set @Sccessfully =5;
		end catch
	end
end
go



create procedure [dbo].[P_Delete_All] 
(
	@TableName Table_,
	@Sccessfully int output
)
as
begin
	 if(@TableName  like 'Customer')
	begin
		begin try 
			begin Transaction
				if (select count(CustomerId) from [Human].[Customer]) >0
				begin
					delete from Human.Customer ;
					set @Sccessfully =3;
				end
				else
					set @Sccessfully =404;
			commit Transaction
		end try 

		begin catch 
			rollback Transaction
				set @Sccessfully =5;
		end catch
	end
	
	else if(@TableName  like 'Supplier')

	begin
		begin try 
			begin Transaction
				if (select count(SupplierId) from Human.Supplier) > 0
				begin
					delete from Human.Supplier ;
					set @Sccessfully =1;
				end
				else
					set @Sccessfully =404;
			commit Transaction
		end try 

		begin catch 
			rollback Transaction
				set @Sccessfully =5;
		end catch
	end
	
	else if(@TableName  like 'Product')

	begin
		begin try 
			begin Transaction
				if (select count(ProductId) from Inventory.Product) >0
				begin
					delete from Inventory.Product;
					set @Sccessfully =1;
				end
				else
					set @Sccessfully =404;
			commit Transaction
		end try 

		begin catch 
			rollback Transaction
				set @Sccessfully =5;
		end catch
	end
	
	else if(@TableName  like 'ProductCategory')
	begin
		begin try 
			begin Transaction
				if (select count(ProductCategoryId) from Inventory.ProductCategory) >0
				begin
					delete from Inventory.ProductCategory;
					set @Sccessfully =1;
				end
				else
					set @Sccessfully =404;
			commit Transaction
		end try 

		begin catch 
			rollback Transaction
				set @Sccessfully =5;
		end catch
	end
	
	else if(@TableName  like 'Store')
	begin
		begin try 
			begin Transaction
				if (select count(StoreId) from Inventory.Store) >0
				begin
					delete from Inventory.Store ;
					set @Sccessfully =1;
				end
				else
					set @Sccessfully =404;
			commit Transaction
		end try 

		begin catch 
			rollback Transaction
				set @Sccessfully =5;
		end catch
	end
	
	else if(@TableName  like 'Unit')
	begin
		begin try 
			begin Transaction
				if (select count(UnitId) from Inventory.Unit) >0
				begin
					delete from Inventory.Unit;
					set @Sccessfully =1;
				end
				else
					set @Sccessfully =404;
			commit Transaction
		end try 

		begin catch 
			rollback Transaction
				set @Sccessfully =5;
		end catch
	end
	
	else if(@TableName  like 'PurchasingInvoice')
	begin
		begin try 
			begin Transaction
				if (select count(PurchasingId) from Purchasing.PurchasingInvoice) >0
				begin
					delete from Purchasing.PurchasingInvoice;
					set @Sccessfully =1;
				end
				else
					set @Sccessfully =404;
			commit Transaction
		end try 

		begin catch 
			rollback Transaction
				set @Sccessfully =5;
		end catch
	end
	
	else if(@TableName  like 'PurchasingDetails')
	begin
		begin try 
			begin Transaction
				if (select count(PurchasingDetailsId) from Purchasing.PurchasingDetails) >0
				begin
					delete from Purchasing.PurchasingDetails;
					set @Sccessfully =1;
				end
				else
					set @Sccessfully =404;
			commit Transaction
		end try 

		begin catch 
			rollback Transaction
				set @Sccessfully =5;
		end catch
	end
	
	else if(@TableName  like 'SalesInvoice')
	begin
		begin try 
			begin Transaction
				if (select count(SalesId) from Sales.SalesInvoice) >0
				begin
					delete from Sales.SalesInvoice ;
					set @Sccessfully =1;
				end
				else
					set @Sccessfully =404;
			commit Transaction
		end try 

		begin catch 
			rollback Transaction
				set @Sccessfully =5;
		end catch
	end
	
	else if(@TableName  like 'SalesDetails')
	begin
		begin try 
			begin Transaction
				if (select count(SalesDetailsId) from Sales.SalesDetails) >0
				begin
					delete from Sales.SalesDetails;
					set @Sccessfully =1;
				end
				else
					set @Sccessfully =404;
			commit Transaction
		end try 

		begin catch 
			rollback Transaction
				set @Sccessfully =5;
		end catch
	end
end
go


create procedure [dbo].[P_Update] 
(
		 @TableName Table_,
		 @Name Name_ ='NOT INSERTED',
		 @Email Email ='NOT INSERTED',
		 @Type nvarchar(max) ='NOT INSERTED',
		 @Phone Phone ='NOT INSERTED',
		 @Address Address_ ='NOT INSERTED',
		 @SupplierBrand Brand ='NOT INSERTED',
		 @LastPrice money =0,
		 @StoreId Id = 1,
		 @PurchasingDetailsId Id =1,
		 @ProductId Id =1 ,
		 @ProductCategoryId Id =1 ,
		 @UserId Id =1,
		 @CustomerId Id =1,
		 @SupplierId Id =1 ,
		 @SalesId Id =1 ,
		 @PurchasingId Id =1 ,
		 @SalesDetailsId Id =1,
		 @UnitId Id  =1,
		 @UnitCode nvarchar(max) ='NOT INSERTED',
		 @UnitDesc Description_ ='NOT INSERTED' ,
		 @UnitPrice money =0,
		 @QuantityMinus Quantity = 0,
		 @QuantityPlus Quantity =0,
		 @Quantity Quantity =1 ,
		 @Total money =0 ,
		 @Sccessfully bit output
)
as
begin
	if(@TableName like 'Customer') 
	begin
		begin try 
			begin transaction
			if exists (SELECT * FROM Human.Customer WHERE CustomerId =@CustomerId)
				begin
				UPDATE  [Human].[Customer]
					set CustomerName =@Name ,
						CustomerEmail = @Email ,
						CustomerType=@Type,
						customerPhone =@Phone
					where CustomerId =@CustomerId;
					set @Sccessfully =1;
				end
			else 
				set @Sccessfully =404;
			commit transaction
		end try

		begin catch 
			rollback transaction
			   set @Sccessfully =6;
		end catch
	end

	else if(@TableName  like 'Supplier')
	begin
		begin try 
			begin transaction
			if exists (SELECT * FROM Human.Supplier WHERE SupplierId =@SupplierId)
				begin
				UPDATE  [Human].[Supplier]
					set SupplierName =@Name ,
						SupplierEmail = @Email ,
						SupplierType=@Type,
						SupplierPhone =@Phone
					where SupplierId =@SupplierId;
					set @Sccessfully =1;
				end
			else 
				set @Sccessfully =404;
			commit transaction
		end try

		begin catch 
			rollback transaction
			   set @Sccessfully =6;
		end catch
	end

	else if(@TableName  like 'Product')
	begin
		begin try 
			begin transaction
			if exists (SELECT * FROM Inventory.Product  WHERE ProductId =@ProductId)
				begin
					UPDATE  Inventory.Product 
						set ProductName =@Name ,
							LastPrice = @LastPrice ,
							StoreId=@StoreId,
							UnitId =@UnitId,
							ProductCategoryId=@ProductCategoryId
						where ProductId =@ProductId;
					   set @Sccessfully =1;
				end
			else 
				set @Sccessfully =404;
			commit transaction
		end try

		begin catch 
			rollback transaction
			   set @Sccessfully =6;
		end catch
	end

	else if(@TableName  like 'ProductCategory')
	begin
		begin try 
			begin transaction
				if exists (SELECT * FROM Inventory.ProductCategory WHERE ProductCategoryId =@ProductCategoryId)
					begin
						UPDATE  Inventory.ProductCategory
							set ProductCategoryName =@Name 
							where ProductCategoryId =@ProductCategoryId;
						   set @Sccessfully =1;
					end
				else 
					set @Sccessfully =404;
			commit transaction
		end try

		begin catch 
			rollback transaction
			   set @Sccessfully =6;
		end catch			
	end

	else if(@TableName  like 'Store')
	begin
		begin try 
			if exists (SELECT * FROM Inventory.Store WHERE StoreId =@StoreId)
				begin
				begin transaction
					UPDATE  Inventory.Store
						set StoreName =@Name ,
							StoreAddress =@Address,
							StorePhone =@Phone
						where StoreId =@StoreId;
					   set @Sccessfully =1;
				end
			else 
				set @Sccessfully =404;
			commit transaction
		end try

		begin catch 
			rollback transaction
			   set @Sccessfully =6;
		end catch
	end

	else if(@TableName  like 'Unit')
	begin
		begin try 
			begin transaction
			
			if exists (SELECT * FROM Inventory.Unit WHERE UnitId =@UnitId)
				begin
					UPDATE  Inventory.Unit
						set UnitCode =@UnitCode ,
							UnitDesc =@UnitDesc
						where UnitId =@UnitId;
					   set @Sccessfully =1;
				end
			else 
				set @Sccessfully =404;
			commit transaction
		end try

		begin catch 
			rollback transaction
			   set @Sccessfully =6;
		end catch
	end

	else if(@TableName  like 'PurchasingInvoice')
	begin
		begin try 
			begin transaction	
			if exists (SELECT * FROM Purchasing.PurchasingInvoice WHERE PurchasingId =@PurchasingId)
				begin	
				UPDATE  Purchasing.PurchasingInvoice 
						set PurchasingTotal =@Total ,
							SupplierId =@SupplierId ,
							UserId = @UserId,
							StoreId = @StoreId
						where PurchasingId =@PurchasingId;
					   set @Sccessfully =1;
				end
			else 
				set @Sccessfully =404;
			commit transaction
		end try

		begin catch 
			rollback transaction
			   set @Sccessfully =6;
		end catch
	end

	else if(@TableName  like 'PurchasingDetails')
	begin
		begin try 
			rollback transaction	
			if exists (SELECT * FROM Purchasing.PurchasingDetails WHERE PurchasingDetailsId =@PurchasingDetailsId)
				begin
				UPDATE  Purchasing.PurchasingDetails 
						set Quantity =@Quantity ,
							UnitPrice =@UnitPrice ,
							ProductId = @ProductId,
							PurchasingId = @PurchasingId
						where PurchasingDetailsId =@PurchasingDetailsId;
					   set @Sccessfully =1;
					   
				end
			else 
				set @Sccessfully =404;
			rollback transaction
			set @Sccessfully =6;
		end try

		begin catch 
			rollback transaction
			   set @Sccessfully =2;
		end catch
	end

	else if(@TableName  like 'SalesInvoice')
	begin
		begin try 	
			begin transaction	
			if exists (SELECT * FROM Sales.SalesInvoice WHERE SalesId =@SalesId)
				begin	
				UPDATE  Sales.SalesInvoice 
						set SalesTotal =@Total ,
							CustomerId =@CustomerId ,
							UserId = @UserId,
							StoreId = @StoreId
						where SalesId =@SalesId;
					   set @Sccessfully =1;
				commit transaction
				   set @Sccessfully =1;
				   
				end
			else 
				set @Sccessfully =404;
		end try

		begin catch 
			rollback transaction
			   set @Sccessfully =6;
		end catch
	end
	
	else if(@TableName  like 'SalesDetails')
	begin
		begin try 
		--begin transaction
			begin transaction	
			
			if exists (SELECT * FROM Sales.SalesDetails WHERE SalesDetailsId =@SalesDetailsId)
				begin
				UPDATE  Sales.SalesDetails 
						set Quantity =@Quantity ,
							UnitPrice =@UnitPrice ,
							ProductId = @ProductId,
							SalesId = SalesId
						where SalesDetailsId =@SalesDetailsId;
					   set @Sccessfully =1;
						--INSERT INTO Inventory.Transactions 
						--	(TransactionType,TransactionNumber,TransactionDate,UnitPrice,QuantityPlus,QuantityMinus,ProductId)
						--	values (N'مبيعات',@SalesId,(SELECT SalesDate FROM sales.SalesInvoice WHERE SalesId= @SalesId),@UnitPrice,@QuantityPlus,@QuantityMinus,@ProductId);
						--   set @Sccessfully =1;
					--end
					--else 
					--begin
					--	ROLLBACK TRANSACTION
					--	set @Sccessfully =3;
					--end
				end
			else 
				set @Sccessfully =404;
			COMMIT TRANSACTION
		--End transaction
		end try

		begin catch 
			ROLLBACK TRANSACTION
			   set @Sccessfully =6;
		end catch

	end

end
go



create procedure [dbo].[P_Select] 
(
	@TableName Table_,
	@Id Id,
	@Sccessfully Id out
)
as
begin

	if(@TableName  like 'Customer')
	begin
		begin try 
			if exists (select * from [Customer] WHERE Id =@Id)
				begin
				select * from [Customer] WHERE Id =@Id;
				end
			else 
				set @Sccessfully =404;
		end try

		begin catch 
			set @Sccessfully =10;
		end catch
	end
	
	else if(@TableName  like 'Supplier')
	begin
		begin try 
			if exists (select * from [Supplier] WHERE Id =@Id)
				begin
				select * from [Supplier] WHERE Id =@Id;
				end
			else 
				set @Sccessfully =404;
		end try

		begin catch 
			set @Sccessfully =10;
		end catch
	end
	
	else if(@TableName  like 'Product')
	begin
		begin try 
			if exists (select * from [Product] WHERE Id =@Id)
				begin
				SELECT * FROM [Product] WHERE Id =@Id;
				end
			else 
				set @Sccessfully =404;
		end try

		begin catch 
			set @Sccessfully =10;
		end catch
	end
	
	else if(@TableName  like 'ProductCategory')
	begin
		begin try 
			if exists (select * from [ProductCategory]WHERE Id =@Id)
				begin
				SELECT * FROM [ProductCategory] WHERE Id =@Id;
				end
			else 
				set @Sccessfully =404;
		end try

		begin catch 
			set @Sccessfully =10;
		end catch
	end
	
	else if(@TableName  like 'Store')
	begin
		begin try 
			if exists (select * from [Store] WHERE Id =@Id)
				begin
				SELECT * FROM [Store] WHERE Id =@Id;
				set @Sccessfully =1;
				end
			else 
				set @Sccessfully =404;
		end try

		begin catch 
			set @Sccessfully =10;
		end catch
	end
	
	else if(@TableName  like 'Unit')
	begin
		begin try 
			if exists (select * from [Unit] WHERE Id =@Id)
				begin
				SELECT * FROM [Unit] WHERE Id =@Id;
				set @Sccessfully =1;
				end
			else 
				set @Sccessfully =404;
		end try

		begin catch 
			set @Sccessfully =10;
		end catch
	end
	
	else if(@TableName  like 'PurchasingInvoice')
	begin
		begin try 
			if exists (select * from [Purchasing].[PurchasingInvoice] WHERE PurchasingId =@Id)
				begin
				SELECT * FROM [Purchasing].[PurchasingInvoice] WHERE PurchasingId =@Id;
				set @Sccessfully =1;
				end
			else 
				set @Sccessfully =404;
		end try

		begin catch 
			set @Sccessfully =10;
		end catch
	end
	
	else if(@TableName  like 'PurchasingDetails')
	begin
		begin try 
			if exists (select * from [Purchasing].[PurchasingDetails] WHERE PurchasingDetailsId =@Id)
				begin
				SELECT * FROM [Purchasing].[PurchasingDetails] WHERE PurchasingDetailsId =@Id;
				set @Sccessfully =1;
				end
			else 
				set @Sccessfully =404;
		end try

		begin catch 
			set @Sccessfully =10;
		end catch
	end
	
	else if(@TableName  like 'SalesInvoice')
	begin
		begin try 
			if exists (select * from [Sales].[SalesInvoice] WHERE SalesId =@Id) 
				begin
				SELECT * FROM [Sales].[SalesInvoice] WHERE SalesId =@Id;
				set @Sccessfully =1;
				end
			else 
				set @Sccessfully =404;
		end try

		begin catch 
			set @Sccessfully =10;
		end catch
	end
	
	else if(@TableName  like 'SalesDetails')
	begin
		begin try 
			if exists (select * from  [Sales].[SalesDetails] WHERE SalesDetailsId =@Id)
				begin
				SELECT * FROM [Sales].[SalesDetails] WHERE SalesDetailsId =@Id;
				set @Sccessfully =1;
				end
			else 
				set @Sccessfully =404;
		end try

		begin catch 
			set @Sccessfully =10;
		end catch
	end
end
go


create procedure [dbo].[P_Select_All] 
(
	@TableName Table_,
	@Sccessfully bit out
)
as
begin
	
	if(@TableName  like 'User_')
	begin
		begin try 
			if (select count(Id) from User_)  >0
				begin
				SELECT * FROM User_;
				end
			else 
				set @Sccessfully =404;
		end try

		begin catch 
			set @Sccessfully =10;
		end catch
	end
	else if(@TableName  like 'Orders')
	begin
		begin try 
			if (select count(OrderID) from Orders) >0
				begin
				select * from Orders;
				end
			else 
				set @Sccessfully =404;
		end try

		begin catch 
			set @Sccessfully =10;
		end catch
	end
	else if(@TableName  like 'Invoices')
	begin
		begin try 
			if (select count(InvoiceID) from Invoices) >0
				begin
				select * from Invoices;
				end
			else 
				set @Sccessfully =404;
		end try

		begin catch 
			set @Sccessfully =10;
		end catch
	end
	
	else if(@TableName  like 'Customer')
	begin
		begin try 
			if (select count(Id) from Customer) >0
				begin
				select * from Customer;
				end
			else 
				set @Sccessfully =404;
		end try

		begin catch 
			set @Sccessfully =10;
		end catch
	end
	
	else if(@TableName  like 'Supplier')
	begin
		begin try 
			if (select count(Id) from Supplier) > 0
				begin
				select * from Supplier;
				end
			else 
				set @Sccessfully =404;
		end try

		begin catch 
			set @Sccessfully =10;
		end catch
	end
	
	else if(@TableName  like 'Product')
	begin
		begin try 
			if (select count(Id) from Product) >0
				begin
				SELECT * FROM Product;
				end
			else 
				set @Sccessfully =404;
		end try

		begin catch 
			set @Sccessfully =10;
		end catch
	end
	
	else if(@TableName  like 'ProductCategory')
	begin
		begin try 
			if (select count(Id) from ProductCategory) >0
				begin
				SELECT * FROM ProductCategory;
				end
			else 
				set @Sccessfully =404;
		end try

		begin catch 
			set @Sccessfully =10;
		end catch
	end
	
	else if(@TableName  like 'Store')
	begin
		begin try 
			if (select count(Id) from Store) >0
				begin
				SELECT * FROM Store;
				end
			else 
				set @Sccessfully =404;
		end try

		begin catch 
			set @Sccessfully =10;
		end catch
	end
	
	else if(@TableName  like 'Unit')
	begin
		begin try 
			if (select count(Id) from Unit)  >0
				begin
				SELECT * FROM Unit;
				end
			else 
				set @Sccessfully =404;
		end try

		begin catch 
			set @Sccessfully =10;
		end catch
	end
	
	else if(@TableName  like 'PurchasingInvoice')
	begin
		begin try 
			if (select count(PurchasingId) from [Purchasing].[PurchasingInvoice]) >0
				begin
				SELECT * FROM [Purchasing].[PurchasingInvoice];
				end
			else 
				set @Sccessfully =404;
		end try

		begin catch 
			set @Sccessfully =10;
		end catch
	end
	
	else if(@TableName  like 'PurchasingDetails')
	begin
		begin try 
			if (select count(PurchasingDetailsId) from [Purchasing].[PurchasingDetails]) >0
				begin
				SELECT * FROM [Purchasing].[PurchasingDetails];
				end
			else 
				set @Sccessfully =404;
		end try

		begin catch 
			set @Sccessfully =10;
		end catch
	end
	
	else if(@TableName  like 'SalesInvoice')
	begin
		begin try 
			if (select count(SalesId) from [Sales].[SalesInvoice] ) >0
				begin
				SELECT * FROM [Sales].[SalesInvoice] ;
				end
			else 
				set @Sccessfully =404;
		end try

		begin catch 
			set @Sccessfully =10;
		end catch
	end
	
	else if(@TableName  like 'Transaction')
	begin
		begin try 
			if ( select count(TransactionId) from  [Inventory].[Transactions] ) >0
				begin
				SELECT * FROM [Inventory].[Transactions] ;
				end
			else 
				set @Sccessfully =404;
		end try

		begin catch 
			set @Sccessfully =10;
		end catch
	end 
	else if(@TableName  like 'SalesDetails')
	begin
		begin try 
			if ( select count(SalesDetailsId) from  [Sales].[SalesDetails] ) >0
				begin
				SELECT * FROM [Sales].[SalesDetails] ;
				end
			else 
				set @Sccessfully =404;
		end try

		begin catch 
			set @Sccessfully =10;
		end catch
	end
end
go

Insert into [Human].[Department] values(N'مدراء');
Insert into [Human].[Department] values(N'مبيعات');
Insert into [Human].[Department] values(N'مشتريات');
Insert into [Human].[Department] values(N'مخازن');
go
select * from [Human].[Department]
go

 create procedure P_User_Insert 
 (@Name Name_ ,@Password Password_, @DepartmentId Id, @UserStatus tinyint =0,@Sccessfully bit output)
as 
begin
	begin try 
		begin transaction
			INSERT INTO [Human].[User_](UserName, UserPassword,UserStatus,DepartmentId) VALUES(@Name, @Password ,@UserStatus,@DepartmentId);
				set @Sccessfully =1;
		commit transaction
	end try

	begin catch 
		rollback transaction
			set @Sccessfully =2;
	end catch
end
go
P_User_Insert 'Admin','Admin',1,1,1
go
P_User_Insert 'sales','sales',2,1,1
go
P_User_Insert 'Pay','Pay',3,1,1
go
P_User_Insert 'store','store',4,1,1
go
P_User_Insert 'Abdullah','Abdullah',1,0,1
go
select * from User_
go

-------------------------------------------End create procedure-----------------------------------------------

alter database salesManagementSystem set Query_store =on
go
alter database salesManagementSystem set query_store 
(OPERATION_MODE= REad_Write ,DATA_FLUSH_INTERVAL_SECONDS=60,
INTERVAL_LENGTH_MINUTES=1)
GO

-------------------------------------------------------------------------------
create Login [Admin]  with password ='Admin'
go
create role Role_Admin 
go
create user [User_Admin] for login [Admin]
go
grant insert,update,delete on schema ::Human TO Role_Admin
go
grant insert,update,delete on schema ::Sales TO Role_Admin
go
grant insert,update,delete on schema ::Inventory TO Role_Admin
go
grant insert,update,delete on schema ::Purchasing TO Role_Admin
go
alter role Role_Admin add MEMBER User_Admin
go
-------
CREATE LOGIN [Sales] WITH PASSWORD='Sales'
go
create role Role_Sales
go
create user User_Sales for login Sales
go
grant select on Schema ::Sales To Role_Sales
go
alter role Role_Sales add MEMBER User_Sales 
go
------
CREATE LOGIN Admin2 WITH PASSWORD=N'Admin2'
go
create user User_Admin2 for login Admin2
go
create role Role_Admin2
go
grant insert,update,delete on schema ::Human TO Role_Admin2
go
grant insert,update,delete on schema ::Sales TO Role_Admin2
go
grant insert,update,delete on schema ::Inventory TO Role_Admin2
go
grant insert,update,delete on schema ::Purchasing TO Role_Admin2
go
alter role Role_Admin2 add MEMBER User_Admin2 --يضيف رول للمستخدم 
--------------------------------------------
--------------------------------------------
CREATE LOGIN Human WITH PASSWORD=N'Human'
go
create user User_Human for login Human
go
create role Role_Human
go
grant Select on Schema ::Human TO role_Human
go
grant Select on Schema ::Sales TO role_Human
go
grant Select on Schema ::Purchasing TO role_Human
go
alter role Role_Human add MEMBER User_Human 
go
--
SET TRANSACTION ISOLATION LEVEL READ COMMITTED;
BEGIN TRANSACTION;
SELECT * FROM Sales.SalesOrderDetail WHERE SalesOrderID = 43659;
COMMIT;

--b--
SET TRANSACTION ISOLATION LEVEL REPEATABLE READ;
BEGIN TRANSACTION;
SELECT * FROM Sales.SalesOrderDetail WHERE SalesOrderID = 43659;
COMMIT;

--c--
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;
BEGIN TRANSACTION;
SELECT * FROM Sales.SalesOrderDetail WHERE SalesOrderID = 43659;

COMMIT;
go

BACKUP DATABASE [SalesManagementSystem] TO DISK = N'E:\DB\backup\main.bak' WITH NOFORMAT, NOINIT,  NAME = N'COMPANYS-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10
GO



BACKUP DATABASE [SalesManagementSystem] TO  DISK = N'E:\DB\backup\Main.bak' WITH  DIFFERENTIAL , NOFORMAT, NOINIT,  NAME = N'COMPANYS-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10 
GO


alter DATABASE SalesManagementSystem set recovery Full


    BACKUP LOG [SalesManagementSystem] TO  DISK = N'E:\DB\backup\main.bak' WITH NOFORMAT,    NOINIT,  NAME = N'COMPANYS-Full Database Backup', SKIP, NOREWIND, NOUNLOAD, 
    STATS = 10
GO
    backup log [SalesManagementSystem] TO  DISK = N' E:\DB\backup\main.df'  


    BACKUP LOG [SalesManagementSystem] TO  DISK = N'E:\DB\backup\main.bak' WITH NOFORMAT,    NOINIT,  NAME = N'COMPANYS-Full Database Backup', SKIP, NOREWIND, NOUNLOAD, 
    STATS = 10
GO
backup database [SalesManagementSystem] TO disk= N' E:\DB\backup\Weekly.bak' WITH init 
go

backup log SalesManagementSystem to disk= N' E:\DB\backup\horely.trn'
go

backup database SalesManagementSystem TO disk= N' E:\DB\backup\compertion.bak'
 with differential, compression

 Restore database SalesManagementSystem from disk=N' E:\DB\backup\comprtitions.bak' with replace,recovery


 --a--
SET TRANSACTION ISOLATION LEVEL READ COMMITTED;
BEGIN TRANSACTION;
SELECT * FROM Sales.SalesOrderDetail WHERE SalesOrderID = 43659;
COMMIT;

--b--
SET TRANSACTION ISOLATION LEVEL REPEATABLE READ;
BEGIN TRANSACTION;
SELECT * FROM Sales.SalesOrderDetail WHERE SalesOrderID = 43659;
COMMIT;

--c--
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;
BEGIN TRANSACTION;
SELECT * FROM Sales.SalesOrderDetail WHERE SalesOrderID = 43659;
COMMIT;
