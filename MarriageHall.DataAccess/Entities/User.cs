using MarriageHall.DataAccess.Enums;

namespace MarriageHall.DataAccess.Entities;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public string UserName { get; set; }
    public bool Gender { get; set; }
    public string Address { get; set; }
    public byte[] PasswordHash { get; set; }
    public byte[] PasswordSalt { get; set; }
    public PermissionEnum PermissionId { get; set; }
}