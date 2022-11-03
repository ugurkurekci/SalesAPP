using System.ComponentModel.DataAnnotations;

namespace Sales.Api.Domain.Entity;

public class EntityBase
{

    public DateTime CreateDate { get; set; }

    public bool IsDeleted { get; set; }

}