use master
go

drop database if exists SalesManagementSystem;
go
-------------------------------------------create database-----------------------------------------------
create database SalesManagementSystem
on primary 
(Name='Main' ,filename='E:\DB\SaleManagementSystem\Main.mdf' , SIZE = 50MB ,filegrowth= 10%),
FileGroup [Human]
(Name='Human_M' ,filename='E:\DB\SaleManagementSystem\Human_M.ldf' ,size =8MB ,filegrowth=1024KB),
(Name='Human_S' ,filename='E:\DB\SaleManagementSystem\Human_S.ldf' ,size =8MB ,filegrowth=1024KB),
FileGroup [Inventory]
(Name='Inventory_M' ,filename='E:\DB\SaleManagementSystem\Inventory_M.ldf' ,size =8MB ,filegrowth=1024KB),
(Name='Inventory_S' ,filename='E:\DB\SaleManagementSystem\Inventory_S.ldf' ,size =8MB ,filegrowth=1024KB),
FileGroup [Purchasing]
(Name='Purchasing_M' ,filename='E:\DB\SaleManagementSystem\Purchasing_M.ldf' ,size =8MB ,filegrowth=1024KB),
(Name='Purchasing_S' ,filename='E:\DB\SaleManagementSystem\Purchasing_S.ldf' ,size =8MB ,filegrowth=1024KB),
FileGroup [Sales]
(Name='Sales_M' ,filename='E:\DB\SaleManagementSystem\Sales_M.ldf' ,size =8MB ,filegrowth=1024KB),
(Name='Sales_S' ,filename='E:\DB\SaleManagementSystem\Sales_S.ldf' ,size =8MB ,filegrowth=1024KB)
LOG ON 
(Name='Log' ,filename='E:\DB\SaleManagementSystem\Log\Log.ldf' ,SIZE =15MB ,filegrowth=5MB)
go

-------------------------------------------End create database-----------------------------------------------
use SalesManagementSystem
go

-------------------------------------------create schema-----------------------------------------------
CREATE schema Human;
GO

create schema [Inventory];
go
create schema [Purchasing];
go

create schema [Sales];
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
create table Human.Department (
DepartmentId Id identity(1,1) primary key,
DepartmentName SName unique

)
create table Human.User_ (
UserId Id identity(1,1) primary key,
UserName SName unique,
UserPassword Password_ unique,
UserStatus tinyint default 0 check (UserStatus in(1,0)),
DepartmentId Id foreign key references Human.Department(DepartmentId)
)
go

create table Inventory.Unit (
UnitId Id identity(1,1) primary key ,
UnitCode nvarchar(30) not null unique ,
UnitDesc description_ 
)
go

create table Inventory.ProductCategory (
ProductCategoryId Id identity(1,1) primary key ,
ProductCategoryName SName unique ,
ModifiedDate datetime default SYSDATETIME()
)
go

create table Human.Customer (
CustomerId Id primary key identity(1,1),
CustomerName Name_,
CustomerEmail Email,
CustomerType nvarchar(max) not null default 'Local' ,
customerPhone Phone
)
go

create table Human.Supplier (
SupplierId Id primary key identity(1,1),
SupplierName Name_,
SupplierEmail Email,
SupplierType nvarchar(max) not null default 'Local' ,
SupplierPhone Phone ,
SupplierBrand Brand
)
go


create table Inventory.Store (
StoreId Id primary key identity(1,1),
StoreName Name_,
StoreAddress Address_,
StorePhone Phone ,
)
go

create table Inventory.Product (
ProductId Id primary key identity(1,1),
ProductName Name_,
ProductNumber nvarchar(max) not null,
LastPrice money not null,
StoreId Id foreign key references Inventory.Store(StoreId) ,
UnitId Id foreign key references Inventory.Unit (UnitId) ,
ProductCategoryId Id foreign key references Inventory.ProductCategory (ProductCategoryId)
)
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
)
go

create table Purchasing.PurchasingInvoice (
PurchasingId Id identity(1,1) primary key,
PurchasingDate datetime default SYSDATETIME(),
PurchasingTotal money not null,
SupplierId Id foreign key references  Human.Supplier(SupplierId),
UserId Id foreign key references Human.User_(UserId),
StoreId Id foreign key references Inventory.Store(StoreId)
)
go

create table Purchasing.PurchasingDetails (
PurchasingDetailsId Id identity(1,1) primary key,
Quantity Quantity default 1,
UnitPrice money not null ,
ProductId Id foreign key references  Inventory.Product(ProductId),
PurchasingId Id foreign key references Purchasing.PurchasingInvoice(PurchasingId)
)
go

create table Sales.SalesInvoice (
SalesId Id identity(1,1) primary key,
SalesDate datetime default SYSDATETIME(),
SalesTotal money not null,
CustomerId Id foreign key references  Human.Customer(CustomerId),
UserId Id foreign key references Human.User_(UserId),
StoreId Id foreign key references Inventory.Store(StoreId)
)
go

create table Sales.SalesDetails (
SalesDetailsId Id identity(1,1) primary key,
Quantity Quantity default 1,
UnitPrice money not null ,
ProductId Id foreign key references  Inventory.Product(ProductId),
SalesId Id foreign key references Sales.SalesInvoice(SalesId)
)
go

-------------------------------------------End create Table-----------------------------------------------




-------------------------------------------create procedure-----------------------------------------------
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
					set @Sccessfully =4;
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
					set @Sccessfully =4;
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
					set @Sccessfully =4;
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
					set @Sccessfully =4;
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
					set @Sccessfully =4;
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
					set @Sccessfully =4;
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
					set @Sccessfully =4;
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
					set @Sccessfully =4;
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
					set @Sccessfully =4;
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
					set @Sccessfully =4;
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
					set @Sccessfully =4;
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
					set @Sccessfully =4;
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
					set @Sccessfully =4;
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
					set @Sccessfully =4;
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
					set @Sccessfully =4;
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
					set @Sccessfully =4;
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
					set @Sccessfully =4;
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
					set @Sccessfully =4;
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
					set @Sccessfully =4;
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
					set @Sccessfully =4;
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
				set @Sccessfully =4;
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
				set @Sccessfully =4;
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
				set @Sccessfully =4;
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
					set @Sccessfully =4;
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
				set @Sccessfully =4;
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
				set @Sccessfully =4;
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
				set @Sccessfully =4;
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
				set @Sccessfully =4;
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
				set @Sccessfully =4;
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
				set @Sccessfully =4;
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
			if exists (select * from [Human].[Customer] WHERE CustomerId =@Id)
				begin
				select * from [Human].[Customer] WHERE CustomerId =@Id;
				set @Sccessfully =1;
				end
			else 
				set @Sccessfully =4;
		end try

		begin catch 
			set @Sccessfully =10;
		end catch
	end
	
	else if(@TableName  like 'Supplier')
	begin
		begin try 
			if exists (select * from [Human].[Supplier] WHERE SupplierId =@Id)
				begin
				select * from [Human].[Supplier] WHERE SupplierId =@Id;
				set @Sccessfully =1;
				end
			else 
				set @Sccessfully =4;
		end try

		begin catch 
			set @Sccessfully =10;
		end catch
	end
	
	else if(@TableName  like 'Product')
	begin
		begin try 
			if exists (select * from [Inventory].[Product] WHERE ProductId =@Id)
				begin
				SELECT * FROM [Inventory].[Product] WHERE ProductId =@Id;
				set @Sccessfully =1;
				end
			else 
				set @Sccessfully =4;
		end try

		begin catch 
			set @Sccessfully =10;
		end catch
	end
	
	else if(@TableName  like 'ProductCategory')
	begin
		begin try 
			if exists (select * from [Inventory].[ProductCategory] WHERE ProductCategoryId =@Id)
				begin
				SELECT * FROM [Inventory].[ProductCategory] WHERE ProductCategoryId =@Id;
				set @Sccessfully =1;
				end
			else 
				set @Sccessfully =4;
		end try

		begin catch 
			set @Sccessfully =10;
		end catch
	end
	
	else if(@TableName  like 'Store')
	begin
		begin try 
			if exists (select * from [Inventory].[Store] WHERE StoreId =@Id)
				begin
				SELECT * FROM [Inventory].[Store] WHERE StoreId =@Id;
				set @Sccessfully =1;
				end
			else 
				set @Sccessfully =4;
		end try

		begin catch 
			set @Sccessfully =10;
		end catch
	end
	
	else if(@TableName  like 'Unit')
	begin
		begin try 
			if exists (select * from [Inventory].[Unit] WHERE UnitId =@Id)
				begin
				SELECT * FROM [Inventory].[Unit] WHERE UnitId =@Id;
				set @Sccessfully =1;
				end
			else 
				set @Sccessfully =4;
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
				set @Sccessfully =4;
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
				set @Sccessfully =4;
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
				set @Sccessfully =4;
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
				set @Sccessfully =4;
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
	@Sccessfully int out
)
as
begin

	if(@TableName  like 'Customer')
	begin
		begin try 
			if (select count(CustomerId) from [Human].[Customer]) >0
				begin
				select * from [Human].[Customer];
				set @Sccessfully =1;
				end
			else 
				set @Sccessfully =4;
		end try

		begin catch 
			set @Sccessfully =10;
		end catch
	end
	
	else if(@TableName  like 'Supplier')
	begin
		begin try 
			if (select count(SupplierId) from [Human].[Supplier]) > 0
				begin
				select * from [Human].[Supplier];
				set @Sccessfully =1;
				end
			else 
				set @Sccessfully =4;
		end try

		begin catch 
			set @Sccessfully =10;
		end catch
	end
	
	else if(@TableName  like 'Product')
	begin
		begin try 
			if (select count(ProductId) from [Inventory].[Product]) >0
				begin
				SELECT * FROM [Inventory].[Product];
				set @Sccessfully =1;
				end
			else 
				set @Sccessfully =4;
		end try

		begin catch 
			set @Sccessfully =10;
		end catch
	end
	
	else if(@TableName  like 'ProductCategory')
	begin
		begin try 
			if (select count(ProductCategoryId) from [Inventory].[ProductCategory]) >0
				begin
				SELECT * FROM [Inventory].[ProductCategory];
				set @Sccessfully =1;
				end
			else 
				set @Sccessfully =4;
		end try

		begin catch 
			set @Sccessfully =10;
		end catch
	end
	
	else if(@TableName  like 'Store')
	begin
		begin try 
			if (select count(StoreId) from [Inventory].[Store]) >0
				begin
				SELECT * FROM [Inventory].[Store];
				set @Sccessfully =1;
				end
			else 
				set @Sccessfully =4;
		end try

		begin catch 
			set @Sccessfully =10;
		end catch
	end
	
	else if(@TableName  like 'Unit')
	begin
		begin try 
			if (select count(UnitId) from [Inventory].[Unit])  >0
				begin
				SELECT * FROM [Inventory].[Unit];
				set @Sccessfully =1;
				end
			else 
				set @Sccessfully =4;
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
				set @Sccessfully =1;
				end
			else 
				set @Sccessfully =4;
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
				set @Sccessfully =1;
				end
			else 
				set @Sccessfully =4;
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
				set @Sccessfully =1;
				end
			else 
				set @Sccessfully =4;
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
				set @Sccessfully =1;
				end
			else 
				set @Sccessfully =4;
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
 (@name Name_ ,@password Password_, @DepartmentId Id,@UserStatus tinyint =0)
as 
begin

INSERT INTO [Human].[User_]
           (UserName,
		   UserPassword,
		   UserStatus,
		   DepartmentId)
     VALUES
           (@name,
           @password 
           ,@UserStatus,
		   @DepartmentId)


end
go
P_User_Insert 'Admin','Admin',1,1
go
P_User_Insert 'sales','sales',2,1
go
P_User_Insert 'Pay','Pay',3,1
go

P_User_Insert 'store','store',4,1
go
select * from Human.User_
go

-------------------------------------------End create procedure-----------------------------------------------