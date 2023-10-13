
-- SQLINES LICENSE FOR EVALUATION USE ONLY
create table User_ (
UserId int auto_increment primary key,
UserName varchar(50) not null unique,
UserPassword varchar(50) not null unique,
UserPermission tinyint unsigned default 0
);

-- SQLINES LICENSE FOR EVALUATION USE ONLY
create table Unit (
UnitId int auto_increment primary key ,
UnitCode varchar(50) not null unique ,
UnitDesc varchar(50) not null 
);


-- SQLINES LICENSE FOR EVALUATION USE ONLY
create table ProductCategory (
ProductCategoryId int auto_increment primary key ,
ProductCategoryName varchar(50) not null unique ,
ModifiedDate DATE default CURRENT_TIMESTAMP
);


-- SQLINES LICENSE FOR EVALUATION USE ONLY
create table Customer (
CustomerId int primary key auto_increment,
CustomerName varchar(50) not null,
CustomerEmail varchar(50) not null,
CustomerType varchar(50) not null default 'Local' ,
customerPhone varchar(50) not null
);


-- SQLINES LICENSE FOR EVALUATION USE ONLY
create table Supplier (
SupplierId int primary key auto_increment,
SupplierName varchar(50) not null,
SupplierEmail varchar(50) not null,
SupplierType varchar(50) not null default 'Local' ,
SupplierPhone varchar(50) not null ,
SupplierBrand varchar(50) not null
);



-- SQLINES LICENSE FOR EVALUATION USE ONLY
create table Store (
StoreId int primary key auto_increment,
StoreName varchar(50) not null,
StoreAddress varchar(50) not null,
StorePhone varchar(50) not null 
);


-- SQLINES LICENSE FOR EVALUATION USE ONLY
create table Product (
ProductId int primary key auto_increment,
ProductName varchar(50) not null,
ProductNumber varchar(50) not null,
LastPrice decimal(15,4) not null,
ProductCategoryId int not null,
StoreId int not null,  
UnitId int not null,
CONSTRAINT F_Product_Category foreign key (ProductCategoryId) references ProductCategory (ProductCategoryId),
CONSTRAINT F_Product_Unit foreign key(UnitId) references Unit (UnitId) ,
CONSTRAINT F_Product_Store foreign key (StoreId) references Store(StoreId) 
);


-- SQLINES LICENSE FOR EVALUATION USE ONLY
create table Transactions (
TransactionId int primary key auto_increment,
TransactionType varchar(50) not null check (TransactionType in ('مبيعات','مشتريات')),
TransactionNumber int not null,
TransactionDate DATE ,
UnitPrice decimal(15,4) not null,
QuantityPlus int  not null,
QuantityMinus int not null,
ProductId int not null,
CONSTRAINT F_Transactions_Product  foreign key (ProductId) references Product(ProductId)
);

-- SQLINES LICENSE FOR EVALUATION USE ONLY
create table PurchasingInvoice (
PurchasingId int auto_increment primary key,
PurchasingDate DATE default CURRENT_TIMESTAMP,
PurchasingTotal decimal(15,4) not null,
SupplierId int not Null ,
UserId int  not Null , 
StoreId int  not Null ,
CONSTRAINT F_PurchasingInvoice_Supplier foreign key(SupplierId) references Supplier(SupplierId),
CONSTRAINT F_PurchasingInvoice_User_ foreign key(UserId) references User_(UserId),
CONSTRAINT F_PurchasingInvoice_Store foreign key(StoreId) references Store(StoreId)
);

-- SQLINES LICENSE FOR EVALUATION USE ONLY
create table PurchasingDetails (
PurchasingDetailsId int auto_increment primary key,
Quantity int default 1,
UnitPrice decimal(15,4) not null ,
ProductId int not null,
PurchasingId int not null,
CONSTRAINT F_PurchasingDetails_Product foreign key(ProductId) references  Product(ProductId),
CONSTRAINT F_PurchasingDetails_PurchasingInvoice foreign key(PurchasingId) references PurchasingInvoice(PurchasingId)
);

-- SQLINES LICENSE FOR EVALUATION USE ONLY
create table SalesInvoice (
SalesId int auto_increment primary key,
SalesDate DATE default CURRENT_TIMESTAMP,
SalesTotal decimal(15,4) not null,
CustomerId int not Null ,
UserId int  not Null , 
StoreId int  not Null ,
CONSTRAINT F_SalesInvoice_Supplier foreign key (CustomerId) references Customer(CustomerId),
CONSTRAINT F_SalesInvoice_User_ foreign key (UserId) references User_(UserId),
CONSTRAINT F_SalesInvoice_Store foreign key (StoreId) references Store(StoreId)
);

-- SQLINES LICENSE FOR EVALUATION USE ONLY
create table SalesDetails (
SalesDetailsId int auto_increment primary key,
Quantity int default 1,
UnitPrice decimal(15,4) not null ,
ProductId int not null,
SalesId int not null ,
CONSTRAINT F_SalesDetails_Product foreign key (ProductId) references  Product(ProductId),
CONSTRAINT F_SalesDetails_SalesInvoice foreign key (SalesId) references SalesInvoice(SalesId)
);


-- SQLINES LICENSE FOR EVALUATION USE ONLY
DELIMITER //

CREATE procedure `PLogin`
(P_UserName varchar(50), P_UserPassword varchar(50) ,out P_exist int)
begin

	begin 
		if exists(select * from User_ where UserName = P_UserName and UserPassword = P_UserPassword) 
		then
			set P_exist =1 ;
		ELSE 
			set P_exist =0;
		end if;	
	end 

	declare continue handler for sqlexception
	begin 
		set P_exist =0;
	end

end;
//

DELIMITER ;


 

-- SQLINES LICENSE FOR EVALUATION USE ONLY
DELIMITER //

CREATE procedure `P_Get_Next_Id` ( 
P_tableName varchar(50) ,out p_NextId int)
begin
-- SQLINES LICENSE FOR EVALUATION USE ONLY
set p_NextId =
		CASE P_tableName
				WHEN 'Customer' THEN  (select max(CustomerId)+1 from Customer)
				WHEN'Supplier' THEN (select max(SupplierId)+1 from Supplier)
				WHEN'Product' THEN (select max(ProductId)+1 from Product)
				WHEN'ProductCategory' THEN (select max(ProductCategoryId)+1 from ProductCategory)
				WHEN'Store' THEN (select max(StoreId)+1 from Store)
				WHEN'Transactions' THEN (select max(TransactionId)+1 from Transactions)
				WHEN'Unit' THEN (select max(UnitId)+1 from Unit)
				WHEN'PurchasingDetails' THEN (select max(PurchasingDetailsId)+1 from PurchasingDetails)
				WHEN'PurchasingInvoice' THEN (select max(PurchasingId)+1 from PurchasingInvoice)
				WHEN'SalesDetails' THEN (select max(SalesDetailsId)+1 from SalesDetails)
				WHEN'SalesInvoice' THEN (select max(SalesId)+1 from SalesInvoice)
		END;
	
end;
//

DELIMITER ;






declare v_int int 
CALL `P_Get_Next_Id`(P_tableName='Supplier', p_NextId= v_int)
-- SQLINES LICENSE FOR EVALUATION USE ONLY
select v_int




CREATE PROCEDURE P_Insert (
    IN P_TableName VARCHAR(50),
    OUT P_Sccessfully BIT,
    IN P_Name VARCHAR(50) DEFAULT 'NOT INSERTED',
    IN P_Email VARCHAR(50) DEFAULT 'NOT INSERTED',
    IN P_Type VARCHAR(50) DEFAULT 'NOT INSERTED',
    IN P_Phone VARCHAR(50) DEFAULT 'NOT INSERTED',
    IN P_Address VARCHAR(50) DEFAULT 'NOT INSERTED',
    IN P_SupplierBrand VARCHAR(50) DEFAULT 'NOT INSERTED',
    IN P_LastPrice decimal(15,4) DEFAULT 0,
    IN P_StoreId INT DEFAULT 1,
    IN P_ProductId INT DEFAULT 1,
    IN P_ProductCategoryId INT DEFAULT 1,
    IN P_UserId INT DEFAULT 1,
    IN P_CustomerId INT DEFAULT 1,
    IN P_SupplierId INT DEFAULT 1,
    IN P_SalesId INT DEFAULT 1,
    IN P_PurchasingId INT DEFAULT 1,
    IN P_UnitId INT DEFAULT 1,
    IN P_UnitCode VARCHAR(50) DEFAULT 'NOT INSERTED',
    IN P_UnitDesc VARCHAR(50) DEFAULT 'NOT INSERTED',
    IN P_UnitPrice decimal(15,4) DEFAULT 0,
    IN P_QuantityMinus INT DEFAULT 0,
    IN P_QuantityPlus INT DEFAULT 0,
    IN P_Quantity INT DEFAULT 1,
    IN P_Total decimal(15,4) DEFAULT 0
)
as
begin

	if(P_TableName like 'Customer') 
	then
		begin 
			-- SQLINES LICENSE FOR EVALUATION USE ONLY
			INSERT INTO `Customer`
			   (CustomerName ,CustomerEmail ,CustomerType ,customerPhone) 
			   VALUES (P_Name,P_Email ,P_Type,P_Phone);
			   set P_Sccessfully =1;
		end

		declare continue handler for sqlexception
		begin 
			   set P_Sccessfully =0;
		end
	end;
	elseif (P_TableName  like 'Supplier')
	then
		begin 
			-- SQLINES LICENSE FOR EVALUATION USE ONLY
			INSERT INTO `Supplier`
			   (SupplierName ,SupplierEmail ,SupplierType ,SupplierPhone,SupplierBrand) 
			   VALUES (P_Name,P_Email ,P_Type,P_Phone,P_SupplierBrand);
			   set P_Sccessfully =1;
		end

		declare continue handler for sqlexception
		begin 
			   set P_Sccessfully =0;
		end
	end;
	elseif (P_TableName  like 'Product')
	then
		begin 
			-- SQLINES LICENSE FOR EVALUATION USE ONLY
			INSERT INTO `Product` 
				(ProductName,LastPrice,StoreId,UnitId,ProductCategoryId)
				values (P_Name,P_LastPrice,P_StoreId,P_UnitId,P_ProductCategoryId);
			   set P_Sccessfully =1;
		end

		declare continue handler for sqlexception
		begin 
			   set P_Sccessfully =0;
		end
	end;
	elseif (P_TableName  like 'ProductCategory')
	then
		begin 
			-- SQLINES LICENSE FOR EVALUATION USE ONLY
			INSERT INTO `ProductCategory `
				(ProductCategoryName) values (P_Name);
			   set P_Sccessfully =1;
		end

		declare continue handler for sqlexception
		begin 
			   set P_Sccessfully =0;
		end 			
	end;
	elseif (P_TableName  like 'Store')
	then
		begin 
			-- SQLINES LICENSE FOR EVALUATION USE ONLY
			INSERT INTO `Store` 
				(StoreName,StoreAddress,StorePhone)
				values (P_Name ,P_Address,P_Phone);
			   set P_Sccessfully =1;
		end

		declare continue handler for sqlexception
		begin 
			   set P_Sccessfully =0;
		end
	end;
	elseif (P_TableName  like 'Unit')
	then
		begin 
			-- SQLINES LICENSE FOR EVALUATION USE ONLY
			INSERT INTO `Unit` 
				(UnitCode,UnitDesc)
				values (P_UnitCode,P_UnitDesc);
			   set P_Sccessfully =1;
		end

		declare continue handler for sqlexception
		begin 
			   set P_Sccessfully =0;
		end
	end;
	elseif (P_TableName  like 'PurchasingInvoice')
	then
		begin 
			-- SQLINES LICENSE FOR EVALUATION USE ONLY
			INSERT INTO `PurchasingInvoice`
				(PurchasingTotal,SupplierId,UserId,StoreId)
				values (P_Total,P_SupplierId,P_UserId,P_StoreId);
			   set P_Sccessfully =1;
		end

		declare continue handler for sqlexception
		begin 
			   set P_Sccessfully =0;
		end
	end;
	elseif (P_TableName  like 'PurchasingDetails')
	then
		begin 
			-- SQLINES LICENSE FOR EVALUATION USE ONLY
			INSERT INTO `PurchasingDetails`
				(Quantity,UnitPrice,ProductId,PurchasingId)
				values (P_Quantity,P_UnitPrice,P_ProductId,P_PurchasingId);
			-- SQLINES LICENSE FOR EVALUATION USE ONLY
			INSERT INTO `Transactions` 
					(TransactionType,TransactionNumber,TransactionDate,UnitPrice,QuantityPlus,QuantityMinus,ProductId)
					values ('مشتريات',P_PurchasingId,(SELECT PurchasingDate FROM Purchasing.PurchasingInvoice WHERE PurchasingId= P_PurchasingId),P_UnitPrice,P_QuantityPlus,P_QuantityMinus,P_ProductId);
				 
			   set P_Sccessfully =1;
		end

		declare continue handler for sqlexception
		begin 
			   set P_Sccessfully =0;
		end
	end;
	elseif (P_TableName  like 'SalesInvoice')
	then
		begin 
			-- SQLINES LICENSE FOR EVALUATION USE ONLY
			INSERT INTO SalesInvoice
				(SalesTotal,CustomerId,UserId,StoreId)
				values (P_Total,P_CustomerId,P_UserId,P_StoreId);
			   set P_Sccessfully =1;
		end

		declare continue handler for sqlexception
		begin 
			   set P_Sccessfully =0;
		end
	end;
	
	elseif (P_TableName  like 'SalesDetails')
	then
		begin 
			if((select SUM(QuantityPlus-QuantityMinus) from `Transactions` where ProductId =P_ProductId)>P_Quantity)
			then 
				-- SQLINES LICENSE FOR EVALUATION USE ONLY
				INSERT INTO `SalesDetails` 
					(Quantity,UnitPrice,ProductId,SalesId)
					values (P_Quantity,P_UnitPrice,P_ProductId,P_SalesId);
				-- SQLINES LICENSE FOR EVALUATION USE ONLY
				INSERT INTO `Transactions` 
					(TransactionType,TransactionNumber,TransactionDate,UnitPrice,QuantityPlus,QuantityMinus,ProductId)
					values ('مبيعات',P_SalesId,(SELECT SalesDate FROM `SalesInvoice` WHERE SalesId= P_SalesId),P_UnitPrice,P_QuantityPlus,P_QuantityMinus,P_ProductId);
				   set P_Sccessfully =1;
			else 
				set P_Sccessfully =2;
			end if;
		end

		declare continue handler for sqlexception
		begin 
			   set P_Sccessfully =0;
		end

	end;

	end if;
 
end
-- SQLINES LICENSE FOR EVALUATION USE ONLY
delimiter //

create procedure `P_Delete` 
(
	P_TableName varchar(50),
	p_Id int ,
	out P_Sccessfully tinyint
)
begin

	 if(P_TableName  like 'Customer')
	then
		begin 
			   set P_Sccessfully =1;
		end

		declare continue handler for sqlexception
		begin 
			   set P_Sccessfully =0;
		end
	end;
	
	elseif (P_TableName  like 'Supplier')
	then
		begin 
			   set P_Sccessfully =1;
		end

		declare continue handler for sqlexception
		begin 
			   set P_Sccessfully =0;
		end
	end;
	
	elseif (P_TableName  like 'Product')
	then
		begin 
			   set P_Sccessfully =1;
		end

		declare continue handler for sqlexception
		begin 
			   set P_Sccessfully =0;
		end
	end;
	
	elseif (P_TableName  like 'ProductCategory')
	then
		begin 
			   set P_Sccessfully =1;
		end

		declare continue handler for sqlexception
		begin 
			   set P_Sccessfully =0;
		end
	end;
	
	elseif (P_TableName  like 'Store')
	then
		begin 
			   set P_Sccessfully =1;
		end

		declare continue handler for sqlexception
		begin 
			   set P_Sccessfully =0;
		end
	end;
	
	elseif (P_TableName  like 'Unit')
	then
		begin 
			   set P_Sccessfully =1;
		end

		declare continue handler for sqlexception
		begin 
			   set P_Sccessfully =0;
		end
	end;
	
	elseif (P_TableName  like 'PurchasingInvoice')
	then
		begin 
			   set P_Sccessfully =1;
		end

		declare continue handler for sqlexception
		begin 
			   set P_Sccessfully =0;
		end
	end;
	
	elseif (P_TableName  like 'PurchasingDetails')
	then
		begin 
			   set P_Sccessfully =1;
		end

		declare continue handler for sqlexception
		begin 
			   set P_Sccessfully =0;
		end
	end;
	
	elseif (P_TableName  like 'SalesInvoice')
	then
		begin 
			   set P_Sccessfully =1;
		end

		declare continue handler for sqlexception
		begin 
			   set P_Sccessfully =0;
		end
	end;
	
	elseif (P_TableName  like 'SalesDetails')
	then
		begin 
			   set P_Sccessfully =1;
		end

		declare continue handler for sqlexception
		begin 
			   set P_Sccessfully =0;
		end
	end;
 	end if;
//

delimiter ;


 



-- SQLINES LICENSE FOR EVALUATION USE ONLY
delimiter //

create procedure `P_Delete_All` 
(
	P_TableName varchar(50),
	out P_Sccessfully tinyint
)
begin

	 if(P_TableName  like 'Customer')
	then
		begin 
			   set P_Sccessfully =1;
		end

		declare continue handler for sqlexception
		begin 
			   set P_Sccessfully =0;
		end
	end;
	
	elseif (P_TableName  like 'Supplier')
	then
		begin 
			   set P_Sccessfully =1;
		end

		declare continue handler for sqlexception
		begin 
			   set P_Sccessfully =0;
		end
	end;
	
	elseif (P_TableName  like 'Product')
	then
		begin 
			   set P_Sccessfully =1;
		end

		declare continue handler for sqlexception
		begin 
			   set P_Sccessfully =0;
		end
	end;
	
	elseif (P_TableName  like 'ProductCategory')
	then
		begin 
			   set P_Sccessfully =1;
		end

		declare continue handler for sqlexception
		begin 
			   set P_Sccessfully =0;
		end
	end;
	
	elseif (P_TableName  like 'Store')
	then
		begin 
			   set P_Sccessfully =1;
		end

		declare continue handler for sqlexception
		begin 
			   set P_Sccessfully =0;
		end
	end;
	
	elseif (P_TableName  like 'Unit')
	then
		begin 
			   set P_Sccessfully =1;
		end

		declare continue handler for sqlexception
		begin 
			   set P_Sccessfully =0;
		end
	end;
	
	elseif (P_TableName  like 'PurchasingInvoice')
	then
		begin 
			   set P_Sccessfully =1;
		end

		declare continue handler for sqlexception
		begin 
			   set P_Sccessfully =0;
		end
	end;
	
	elseif (P_TableName  like 'PurchasingDetails')
	then
		begin 
			   set P_Sccessfully =1;
		end

		declare continue handler for sqlexception
		begin 
			   set P_Sccessfully =0;
		end
	end;
	
	elseif (P_TableName  like 'SalesInvoice')
	then
		begin 
			   set P_Sccessfully =1;
		end

		declare continue handler for sqlexception
		begin 
			   set P_Sccessfully =0;
		end
	end;
	
	elseif (P_TableName  like 'SalesDetails')
	then
		begin 
			   set P_Sccessfully =1;
		end

		declare continue handler for sqlexception
		begin 
			   set P_Sccessfully =0;
		end
	end;
 	end if;
//

delimiter ;


 


-- SQLINES LICENSE FOR EVALUATION USE ONLY
delimiter //

create procedure `P_Update` 
(
		 P_TableName varchar(50),
		 p_Name varchar(50) /* ='NOT INSERTED' */ ,
		 p_Email varchar(50) /* ='NOT INSERTED' */,
		 p_Type varchar(50) /* ='NOT INSERTED' */,
		 p_Phone varchar(50) /* ='NOT INSERTED' */,
		 p_Address varchar(50) /* ='NOT INSERTED' */,
		 p_SupplierBrand varchar(50) /* ='NOT INSERTED' */,
		 p_LastPrice decimal(15,4) /* =0 */,
		 p_StoreId int /* = 1 */,
		 p_ProductId int /* =1 */ ,
		 p_ProductCategoryId int /* =1 */ ,
		 p_UserId int /* =1 */,
		 p_CustomerId int /* =1 */,
		 p_SupplierId int /* =1 */ ,
		 p_SalesId int /* =1 */ ,
		 p_PurchasingId int /* =1 */ ,
		 p_UnitId int  /* =1 */,
		 p_UnitCode varchar(50) /* ='NOT INSERTED' */,
		 p_UnitDesc varchar(50) /* ='NOT INSERTED' */ ,
		 p_UnitPrice decimal(15,4) /* =0 */,
		 p_QuantityMinus int /* = 0 */,
		 p_QuantityPlus int /* =0 */,
		 p_Quantity int /* =1 */ ,
		 p_Total decimal(15,4) /* =0 */ ,
		 out P_Sccessfully tinyint
)
begin

	 if(P_TableName  like 'Customer')
	then
		begin 
			   set P_Sccessfully =1;
		end

		declare continue handler for sqlexception
		begin 
			   set P_Sccessfully =0;
		end
	end;
	
	elseif (P_TableName  like 'Supplier')
	then
		begin 
			   set P_Sccessfully =1;
		end

		declare continue handler for sqlexception
		begin 
			   set P_Sccessfully =0;
		end
	end;
	
	elseif (P_TableName  like 'Product')
	then
		begin 
			   set P_Sccessfully =1;
		end

		declare continue handler for sqlexception
		begin 
			   set P_Sccessfully =0;
		end
	end;
	
	elseif (P_TableName  like 'ProductCategory')
	then
		begin 
			   set P_Sccessfully =1;
		end

		declare continue handler for sqlexception
		begin 
			   set P_Sccessfully =0;
		end
	end;
	
	elseif (P_TableName  like 'Store')
	then
		begin 
			   set P_Sccessfully =1;
		end

		declare continue handler for sqlexception
		begin 
			   set P_Sccessfully =0;
		end
	end;
	
	elseif (P_TableName  like 'Unit')
	then
		begin 
			   set P_Sccessfully =1;
		end

		declare continue handler for sqlexception
		begin 
			   set P_Sccessfully =0;
		end
	end;
	
	elseif (P_TableName  like 'PurchasingInvoice')
	then
		begin 
			   set P_Sccessfully =1;
		end

		declare continue handler for sqlexception
		begin 
			   set P_Sccessfully =0;
		end
	end;
	
	elseif (P_TableName  like 'PurchasingDetails')
	then
		begin 
			   set P_Sccessfully =1;
		end

		declare continue handler for sqlexception
		begin 
			   set P_Sccessfully =0;
		end
	end;
	
	elseif (P_TableName  like 'SalesInvoice')
	then
		begin 
			   set P_Sccessfully =1;
		end

		declare continue handler for sqlexception
		begin 
			   set P_Sccessfully =0;
		end
	end;
	
	elseif (P_TableName  like 'SalesDetails')
	then
		begin 
			   set P_Sccessfully =1;
		end

		declare continue handler for sqlexception
		begin 
			   set P_Sccessfully =0;
		end
	end;
 	end if;
//

delimiter ;


 



-- SQLINES LICENSE FOR EVALUATION USE ONLY
delimiter //

create procedure `P_Select` 
(
	P_TableName varchar(50),
	p_Id int 
)
begin

	if(P_TableName  like 'Customer')
	then
		begin 
			-- SQLINES LICENSE FOR EVALUATION USE ONLY
			select * from `Customer` WHERE CustomerId =p_Id ;
		end

		declare continue handler for sqlexception
		begin 
			   /* print 'ERROR'; */
		end
	end;
	
	elseif (P_TableName  like 'Supplier')
	then
		begin 
			-- SQLINES LICENSE FOR EVALUATION USE ONLY
			select * from `Supplier` WHERE SupplierId =p_Id;
		end

		declare continue handler for sqlexception
		begin 
			   /* print 'ERROR'; */
		end
	end;
	
	elseif (P_TableName  like 'Product')
	then
		begin 
			-- SQLINES LICENSE FOR EVALUATION USE ONLY
			SELECT * FROM `Product` WHERE ProductId =p_Id;
		end

		declare continue handler for sqlexception
		begin 
			   /* print 'ERROR'; */
		end
	end;
	
	elseif (P_TableName  like 'ProductCategory')
	then
		begin 
			-- SQLINES LICENSE FOR EVALUATION USE ONLY
			SELECT * FROM `ProductCategory` WHERE ProductCategoryId =p_Id;;
		end

		declare continue handler for sqlexception
		begin 
			   /* print 'ERROR'; */
		end
	end;
	
	elseif (P_TableName  like 'Store')
	then
		begin 
			-- SQLINES LICENSE FOR EVALUATION USE ONLY
			SELECT * FROM `Store` WHERE StoreId =p_Id;;
		end

		declare continue handler for sqlexception
		begin 
			   /* print 'ERROR'; */
		end
	end;
	
	elseif (P_TableName  like 'Unit')
	then
		begin 
			-- SQLINES LICENSE FOR EVALUATION USE ONLY
			SELECT * FROM `Unit` WHERE UnitId =p_Id;
		end

		declare continue handler for sqlexception
		begin 
			   /* print 'ERROR'; */
		end
	end;
	
	elseif (P_TableName  like 'PurchasingInvoice')
	then
		begin 
			   -- SQLINES LICENSE FOR EVALUATION USE ONLY
   			SELECT * FROM `PurchasingInvoice` WHERE PurchasingId =p_Id;
		end

		declare continue handler for sqlexception
		begin 
			   /* print 'ERROR'; */
		end
	end;
	
	elseif (P_TableName  like 'PurchasingDetails')
	then
		begin 
			   -- SQLINES LICENSE FOR EVALUATION USE ONLY
   			SELECT * FROM `PurchasingDetails` WHERE PurchasingDetailsId =p_Id;
		end

		declare continue handler for sqlexception
		begin 
			   /* print 'ERROR'; */
		end
	end;
	
	elseif (P_TableName  like 'SalesInvoice')
	then
		begin 
			-- SQLINES LICENSE FOR EVALUATION USE ONLY
			SELECT * FROM `SalesInvoice` WHERE SalesId =p_Id;
		end

		declare continue handler for sqlexception
		begin 
			   /* print 'ERROR'; */
		end
	end;
	
	elseif (P_TableName  like 'SalesDetails')
	then
		begin 
			   -- SQLINES LICENSE FOR EVALUATION USE ONLY
   			sELECT * FROM `SalesDetails` WHERE SalesDetailsId =p_Id;
		end

		declare continue handler for sqlexception
		begin 
			   /* print 'ERROR'; */
		end
	end;
	end if;
//

delimiter ;


 


-- SQLINES LICENSE FOR EVALUATION USE ONLY
delimiter //

create procedure `P_Select_All` 
(
	P_TableName varchar(50)
)
begin

	if(P_TableName  like 'Customer')
	then
		begin 
			-- SQLINES LICENSE FOR EVALUATION USE ONLY
			select * from `Customer`;
		end

		declare continue handler for sqlexception
		begin 
			   /* print 'ERROR'; */
		end
	end;
	
	elseif (P_TableName  like 'Supplier')
	then
		begin 
			-- SQLINES LICENSE FOR EVALUATION USE ONLY
			select * from `Supplier`;
		end

		declare continue handler for sqlexception
		begin 
			   /* print 'ERROR'; */
		end
	end;
	
	elseif (P_TableName  like 'Product')
	then
		begin 
			-- SQLINES LICENSE FOR EVALUATION USE ONLY
			SELECT * FROM `Product`;
		end

		declare continue handler for sqlexception
		begin 
			   /* print 'ERROR'; */
		end
	end;
	
	elseif (P_TableName  like 'ProductCategory')
	then
		begin 
			-- SQLINES LICENSE FOR EVALUATION USE ONLY
			SELECT * FROM `ProductCategory`;
		end

		declare continue handler for sqlexception
		begin 
			   /* print 'ERROR'; */
		end
	end;
	
	elseif (P_TableName  like 'Store')
	then
		begin 
			-- SQLINES LICENSE FOR EVALUATION USE ONLY
			SELECT * FROM `Store`;
		end

		declare continue handler for sqlexception
		begin 
			   /* print 'ERROR'; */
		end
	end;
	
	elseif (P_TableName  like 'Unit')
	then
		begin 
			-- SQLINES LICENSE FOR EVALUATION USE ONLY
			SELECT * FROM `Unit`;
		end

		declare continue handler for sqlexception
		begin 
			   /* print 'ERROR'; */
		end
	end;
	
	elseif (P_TableName  like 'PurchasingInvoice')
	then
		begin 
			   -- SQLINES LICENSE FOR EVALUATION USE ONLY
   			SELECT * FROM `PurchasingInvoice`;
		end

		declare continue handler for sqlexception
		begin 
			   /* print 'ERROR'; */
		end
	end;
	
	elseif (P_TableName  like 'PurchasingDetails')
	then
		begin 
			   -- SQLINES LICENSE FOR EVALUATION USE ONLY
   			SELECT * FROM `PurchasingDetails`;
		end

		declare continue handler for sqlexception
		begin 
			   /* print 'ERROR'; */
		end
	end;
	
	elseif (P_TableName  like 'SalesInvoice')
	then
		begin 
			-- SQLINES LICENSE FOR EVALUATION USE ONLY
			SELECT * FROM `SalesInvoice`;
		end

		declare continue handler for sqlexception
		begin 
			   /* print 'ERROR'; */
		end
	end;
	
	elseif (P_TableName  like 'SalesDetails')
	then
		begin 
			   -- SQLINES LICENSE FOR EVALUATION USE ONLY
   			sELECT * FROM `PurchasingDetails`;
		end

		declare continue handler for sqlexception
		begin 
			   /* print 'ERROR'; */
		end
	end;
	end if;
//

delimiter ;


 


 -- SQLINES LICENSE FOR EVALUATION USE ONLY
 delimiter //

 create procedure pLoginInsert ( 

p_id int, p_name varchar(50), p_email varchar(50))
begin

-- SQLINES LICENSE FOR EVALUATION USE ONLY
INSERT INTO `Login`
           (`id`
           ,`name`
           ,`email`)
     VALUES
           (p_id,
           p_name 
           ,p_email );


end;
 //

delimiter ;


-- SQLINES LICENSE FOR EVALUATION USE ONLY
select * from Human.User_;
 
