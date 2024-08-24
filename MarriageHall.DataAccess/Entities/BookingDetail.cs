namespace MarriageHall.DataAccess.Entities;

public class BookingDetail
{
    public int Id { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    public int FoodId { get; set; }
    public int BookingId { get; set; }
}
