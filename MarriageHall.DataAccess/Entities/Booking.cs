using MarriageHall.DataAccess.Enums;

namespace MarriageHall.DataAccess.Entities;

public class Booking
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public int StaffId { get; set; }
    public int HallId { get; set; }
    public StatusEnum StatusId { get; set; }
    public ShiftEnum ShiftId { get; set; }
    public int NumberOfPeople { get; set; }
    public string Note { get; set; }
    public decimal TotalPrice { get; set; }
    public bool IsPaid { get; set; }
    public DateTimeOffset ServiceDate { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
}
