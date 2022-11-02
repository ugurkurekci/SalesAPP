namespace Sales.Api.Domain.Entity;

public class User : EntityBase
{

    public string Username { get; set; }

    public string EMail { get; set; }

    public string Password { get; set; }

}