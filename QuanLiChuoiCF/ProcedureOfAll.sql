create procedure uspGetEmpolyeeByUserName
@userName nvarchar(100)
as
begin
SELECT * FROM Employee WHERE IDEmployee IN (SELECT Account.IDEmployee FROM Employee,Account WHERE Account.Username=@userName)
end;

create procedure USP_GetBranchByUserName
@Username nvarchar(100)
as 
begin
select Employee.IDBranch from dbo.Account, dbo.Employee where Account.IDEmployee = Employee.IDEmployee and Account.Username = @Username
end;

create procedure USP_Account
as
begin
select * from dbo.Account ORDER BY Username
end;

create procedure USP_GetAccountByUserName
@username nvarchar(100)
as 
begin
select * from dbo.account where Username = @username
end;
create procedure USP_GetBill
as
begin
select * from dbo.Bill ORDER BY IDBill
end;
create procedure USP_GetBilsByBranch
@id nvarchar(100)
as
begin
select * from dbo.Bill where IDBranch = @id ORDER BY IDBill
end;

create procedure USP_GetBillExport
as
begin
select * from dbo.BillExport
end;

create procedure USP_GetBranch
as
begin
select * from Branch ORDER BY IDBranch
end;

create procedure USP_GetNameBrandByID
@id nvarchar(100)
as
begin
select Name from Branch where IDBranch =@id
end;
create procedure USP_GetDetailOfBill
@id nvarchar(100)
as
begin
Select *from dbo.DetailOfBill where  IDbill= @id ORDER BY IDBill, IDDrink
end;

create procedure USP_GetDetailOfBillExport
as
begin
select * from dbo.DetailOfBillExport
end;

create procedure USP_GetDetailOfBillExports
@id nchar(10)
as
begin
select * from dbo.DetailOfBillExport where IDBillExport = @id
end;

create procedure USP_GetDrink
as
begin
select * from dbo.Drink ORDER BY IDDrink
end;

create procedure USP_GetDrinkByID
@id nchar(10)
as
begin
select * from dbo.Drink where IDDrink =@id
end;

create procedure USP_GetEmployee
as
begin
select * from dbo.Employee ORDER BY IDEmployee
end;

create procedure USP_GetNameByIDEmployee
@id nchar(10)
as
begin
select firstname, lastname from dbo.Employee where IDEmployee =@id
end;

create procedure USP_GetEmployeeByID
@id nchar(10)
as
begin
select * from dbo.Employee where IDEmployee = @id
end;

create procedure USP_GetDateOffs
as
begin
select * from dbo.FullTimeEmployeeManagement
end;

create procedure USP_GetDateOffsByIDEmployee
@id nchar(10)
as
begin
select * from dbo.FullTimeEmployeeManagement where IDEmployee =@id
end;

create procedure USP_GetInfoOfMaterials
as
begin
select * from dbo.InforOfMaterial
end;

create procedure USP_GetNameByIDInforMaterial
@id nchar(10)
as
begin
select Name from dbo.InforOfMaterial where IDInfoOfMaterial =@id
end;

create procedure USP_GetInfoOfMaterial
@id nchar(10)
as
begin
select * from dbo.InforOfMaterial where IDInfoOfMaterial = @id
end;

create procedure USO_GetMaterials
as
begin
select * from dbo.Material ORDER BY IDMaterial
end;

create procedure USP_GetMaterialByID
@id nchar(10)
as
begin
select * from dbo.Material where IDMaterial =@id	
end;

create procedure USP_GetDateWorks
as
begin
select * from dbo.PartTimeEmployeeManagement
end;

create procedure USP_GetDateWorksByIDEmployee
@id nchar(10)
as
begin
select * from dbo.PartTimeEmployeeManagement where IDEmployee = @id
end;

create procedure USP_GetSuppliers
as
begin
select * from dbo.Supplier ORDER BY IDSupplier
end;

create procedure USP_GetNameByIDSupplier
@id nchar(10)
as
begin
select Name from dbo.Supplier where IDSupplier =@id
end;