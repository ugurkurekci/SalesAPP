using System.ComponentModel.DataAnnotations;

namespace Sales.Api.Domain.Entity;

public class EntityBase
{

    [Key]
    public int ID { get; set; }

    public DateTime CreateDate { get; set; }

    public bool IsDeleted { get; set; }

}