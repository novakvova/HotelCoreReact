
IF NOT EXISTS (SELECT * FROM sys.procedures WHERE object_id = OBJECT_ID(N'[dbo].[spGetRangeApartments]'))
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[spGetRangeApartments] @From int, @Take int, @JSONOutput NVARCHAR(MAX) OUTPUT
AS
BEGIN
SET @JSONOutput = (
SELECT a.Id,
			a.Name,
			a.Description,
			a.Equipment,
			a.Area,
			a.Price,
			a.RoomQuantity,
			f.Id as [Floor.Id],
			f.Number as [Floor.Number],
			f.Description as [Floor.Description],
			c.Id as [ConvenienceType.Id],
			c.Name as [ConvenienceType.Name],
			r.Id as [RoomType.Id],
			c.Name as [RoomType.Name],
			(
				SELECT i.Id, i.Name FROM tblApartmentImages as i
				WHERE a.Id = i.AppartmentId
				FOR JSON AUTO
			) AS [Images]
		
		FROM tblApartments as a
			INNER JOIN tblFloors as f
				ON a.FloorId = f.Id
			INNER JOIN tblConvenienceTypes as c
				ON a.ConvenienceTypeId = c.Id
			INNER JOIN tblRoomTypes as r
				ON a.RoomTypeId = r.Id
		
		ORDER BY a.Id

		OFFSET     @From ROWS 
		FETCH NEXT @Take ROWS ONLY 
		
		FOR JSON PATH)
END'