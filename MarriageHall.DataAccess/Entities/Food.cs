namespace MarriageHall.DataAccess.Entities;

public class Food
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int CategoryId { get; set; }
}