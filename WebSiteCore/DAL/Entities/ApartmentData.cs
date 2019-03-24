namespace WebSiteCore.DAL.Entities
{
    public class ApartmentData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Equipment { get; set; }
        public double Area { get; set; }
        public double Price { get; set; }
        public int RoomQuantity { get; set; }
        public string Convenience { get; set; }
        public string Room { get; set; }
        public int FloorNumber { get; set; }
        public string FloorDescription { get; set; }
    }
}