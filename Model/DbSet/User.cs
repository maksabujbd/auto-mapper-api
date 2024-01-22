namespace AutoMapper.API.Model.DbSet;

public class User
{
    public Guid Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PostCode { get; set; } = string.Empty;
    public string StreetAddress { get; set; } = string.Empty;
    public DateTime CreateAt { get; set; }
    public int Status { get; set; }
}