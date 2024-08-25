using MarriageHall.DataAccess.Enums;

namespace MarriageHall.DataAccess.Entities;

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public GenderEnum GenderId { get; set; }
    public string Address { get; set; }
}
