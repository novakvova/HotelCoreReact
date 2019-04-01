IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vApartments]'))
EXEC dbo.sp_executesql @statement = N'
CREATE VIEW [dbo].[vApartments]
AS
SELECT        dbo.tblApartments.Id AS ApartmentId, dbo.tblApartments.Name, dbo.tblApartments.Description, dbo.tblApartments.Equipment, dbo.tblApartments.Area, dbo.tblApartments.Price, dbo.tblApartments.RoomQuantity, 
                         dbo.tblApartments.ConvenienceTypeId, dbo.tblConvenienceTypes.Name AS ConvenienceTypeName, dbo.tblApartments.RoomTypeId, dbo.tblRoomTypes.Name AS RoomTypeName, dbo.tblApartments.FloorId, 
                         dbo.tblFloors.Number AS FloorNumber, dbo.tblFloors.Description AS FloorDescription
FROM            dbo.tblApartments INNER JOIN
                         dbo.tblConvenienceTypes ON dbo.tblApartments.ConvenienceTypeId = dbo.tblConvenienceTypes.Id INNER JOIN
                         dbo.tblFloors ON dbo.tblApartments.FloorId = dbo.tblFloors.Id INNER JOIN
                         dbo.tblRoomTypes ON dbo.tblApartments.RoomTypeId = dbo.tblRoomTypes.Id'