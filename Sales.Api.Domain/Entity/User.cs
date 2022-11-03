using System.ComponentModel.DataAnnotations;

namespace Sales.Api.Domain.Entity;

public class User : EntityBase
{

    [Key]
    public int ID { get; set; }

    public string Username { get; set; }

    public string EMail { get; set; }

    public string Password { get; set; }

}