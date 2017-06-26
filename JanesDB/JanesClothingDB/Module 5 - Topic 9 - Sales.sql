--
--Stored procedures for Categories
--
CREATE PROCEDURE sp_Categories_ExistsCategory 
    @Category varchar(100),
	@RecordCount INT OUTPUT
AS
BEGIN    

	SELECT @RecordCount = COUNT(*) 
	FROM Categories
    WHERE Category = @Category
   
END
GO

CREATE PROCEDURE [dbo].[sp_Categories_CreateCategory] 
    @Category varchar(100),
    @NewCategoryID INT OUTPUT
AS
BEGIN    

   INSERT INTO Categories
           (Category)
   VALUES (@Category)
	
	SELECT @NewCategoryID = @@IDENTITY

END
GO

CREATE PROCEDURE sp_Categories_UpdateCategory 
    @CategoryID int,
    @Category varchar(100)
AS
BEGIN    

   UPDATE Categories
      SET Category = @Category
   WHERE CategoryID = @CategoryID
   
END
GO

CREATE PROCEDURE sp_Categories_AllowDeleteCategory 
	@CategoryID INT,
	@RecordCount INT OUTPUT
AS
BEGIN

  DECLARE @tmpRecordCount INT

  SELECT @RecordCount = 0  

  SELECT @tmpRecordCount = COUNT(*) FROM Customers WHERE CategoryID = @CategoryID
  IF @tmpRecordCount > 0 
     SELECT @RecordCount = 1
     
END
GO

CREATE PROCEDURE sp_Categories_DeleteCategory
	@CategoryID INT
AS
BEGIN
	DELETE FROM Categories WHERE CategoryID = @CategoryID
END
GO

CREATE PROCEDURE sp_Categories_GetCategories 
	@CategoryID INT
AS
BEGIN
   IF @CategoryID = 0
      BEGIN
         SELECT * 
	     FROM Categories 
	     ORDER BY Category
	  END
   ELSE	     
      BEGIN
         SELECT * 
	     FROM Categories 
	     WHERE CategoryID = @CategoryID
	  END
END
GO

--
--Stored procedures for Products
--
CREATE PROCEDURE sp_Products_ExistsProduct 
    @BrandID int,
    @ProductDescription varchar(100),
    @Price money,
    @GenderType varchar(1),
    @ColourFast bit,
	@RecordCount INT OUTPUT
AS
BEGIN    

	SELECT @RecordCount = COUNT(*) 
	FROM Products
    WHERE BrandID = @BrandID
      AND ProductDescription = @ProductDescription
      AND Price = @Price
      AND GenderType = @GenderType
      AND ColourFast = @ColourFast
   
END
GO

CREATE PROCEDURE [dbo].[sp_Products_CreateProduct] 
    @BrandID int,
    @ProductDescription varchar(100),
    @Price money,
    @GenderType varchar(1),
    @ColourFast bit,
    @NewProductID INT OUTPUT
AS
BEGIN    

   INSERT INTO Products
           (BrandID,
            ProductDescription,
            Price,
            GenderType,
            ColourFast,
			LastPurchased)
   VALUES (@BrandID,
           @ProductDescription, 
           @Price, 
           @GenderType, 
           @ColourFast,
		   GETDATE())
	
	SELECT @NewProductID = @@IDENTITY

END
GO

CREATE PROCEDURE sp_Products_UpdateProduct 
    @ProductID int,
    @BrandID int,
    @ProductDescription varchar(100),
    @Price money,
    @GenderType varchar(1),
    @ColourFast bit,
AS
BEGIN    

   UPDATE Products
      SET BrandID = @BrandID,
          ProductDescription = @ProductDescription,
          Price = @Price,
          GenderType = @GenderType,
          ColourFast = @ColourFast,
   WHERE ProductID = @ProductID
   
END
GO

CREATE PROCEDURE sp_Products_AllowDeleteProduct 
	@ProductID INT,
	@RecordCount INT OUTPUT
AS
BEGIN

  DECLARE @tmpRecordCount INT

  SELECT @RecordCount = 0  

  SELECT @tmpRecordCount = COUNT(*) FROM SaleProducts WHERE ProductID = @ProductID
  IF @tmpRecordCount > 0 
     SELECT @RecordCount = 1
     
END
GO

CREATE PROCEDURE sp_Products_DeleteProduct
	@ProductID INT
AS
BEGIN
	DELETE FROM Products WHERE ProductID = @ProductID
END
GO

CREATE PROCEDURE sp_Products_GetProducts 
	@ProductID INT
AS
BEGIN
   IF @ProductID = 0
      BEGIN
         SELECT * 
	     FROM Product 
	     ORDER BY ProductDescription
	  END
   ELSE	     
      BEGIN
         SELECT * 
	     FROM Product 
	     WHERE ProductID = @ProductID
	  END
END
GO

--
--Stored procedures for Sizes
--
CREATE PROCEDURE sp_Sizes_ExistsSize 
    @Size varchar(10),
	@RecordCount INT OUTPUT
AS
BEGIN    

	SELECT @RecordCount = COUNT(*) 
	FROM Sizes
    WHERE Size = @Size
   
END
GO

CREATE PROCEDURE [dbo].[sp_Sizes_CreateSize] 
    @Size varchar(10),
    @NewSizeID INT OUTPUT
AS
BEGIN    

   INSERT INTO Sizes
           (Size)
   VALUES (@Size)
	
	SELECT @NewSizeID = @@IDENTITY

END
GO

CREATE PROCEDURE sp_Sizes_UpdateSize 
    @SizeID int,
    @Size varchar(10)
AS
BEGIN    

   UPDATE Sizes
      SET Size = @Size
   WHERE SizeID = @SizeID
   
END
GO

CREATE PROCEDURE sp_Sizes_AllowDeleteSize 
	@SizeID INT,
	@RecordCount INT OUTPUT
AS
BEGIN

  DECLARE @tmpRecordCount INT

  SELECT @RecordCount = 0  

  SELECT @tmpRecordCount = COUNT(*) FROM SaleProducts WHERE SizeID = @SizeID
  IF @tmpRecordCount > 0 
     SELECT @RecordCount = 1
     
  SELECT @tmpRecordCount = COUNT(*) FROM ProductSizes WHERE SizeID = @SizeID
  IF @tmpRecordCount > 0 
     SELECT @RecordCount = 1
     
END
GO

CREATE PROCEDURE sp_Sizes_DeleteSize
	@CategoryID INT
AS
BEGIN
	DELETE FROM Sizes WHERE SizeID = @SizeID
END
GO

CREATE PROCEDURE sp_Sizes_GetSizes 
	@SizeID INT
AS
BEGIN
   IF @SizeID = 0
      BEGIN
         SELECT * 
	     FROM Sizes 
	     ORDER BY Size
	  END
   ELSE	     
      BEGIN
         SELECT * 
	     FROM Sizes 
	     WHERE SizeID = @SizeID
	  END
END
GO


--
--Stored procedures for Brands
--
CREATE PROCEDURE sp_Brands_ExistsBrand 
    @BrandNmae varchar(100),
	@RecordCount INT OUTPUT
AS
BEGIN    

	SELECT @RecordCount = COUNT(*) 
	FROM Brands
    WHERE BrandName = @BrandName
   
END
GO

CREATE PROCEDURE [dbo].[sp_Brands_CreateBrand] 
    @BrandName` varchar(100),
    @NewBrandID INT OUTPUT
AS
BEGIN    

   INSERT INTO Brands
           (BrandName)
   VALUES (@BrandNmae)
	
	SELECT @NewBrandID = @@IDENTITY

END
GO

CREATE PROCEDURE sp_Brands_UpdateBrand 
    @BrandID int,
    @BrandName varchar(100)
AS
BEGIN    

   UPDATE Brands
      SET BrandName = @BrandName
   WHERE BrandID = @BrandID
   
END
GO

CREATE PROCEDURE sp_Brands_AllowDeleteBrand 
	@BrandID INT,
	@RecordCount INT OUTPUT
AS
BEGIN

  DECLARE @tmpRecordCount INT

  SELECT @RecordCount = 0  

  SELECT @tmpRecordCount = COUNT(*) FROM Products WHERE BrandID = @BrandID
  IF @tmpRecordCount > 0 
     SELECT @RecordCount = 1
     
END
GO

CREATE PROCEDURE sp_Brands_DeleteBrand
	@BrandID INT
AS
BEGIN
	DELETE FROM Brands WHERE BrandID = @BrandID
END
GO

CREATE PROCEDURE sp_Brands_GetBrand 
	@BrandID INT
AS
BEGIN
   IF @BrandID = 0
      BEGIN
         SELECT * 
	     FROM Brands 
	     ORDER BY BrandName
	  END
   ELSE	     
      BEGIN
         SELECT * 
	     FROM Brands 
	     WHERE BrandID = @BrandID
	  END
END
GO


