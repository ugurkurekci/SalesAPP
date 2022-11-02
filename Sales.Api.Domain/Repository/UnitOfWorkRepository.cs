using Sales.Api.Domain.DataAccess;
using Sales.Api.Domain.Repository.Abstract;

namespace Sales.Api.Domain.Repository;

public class UnitOfWorkRepository : IUnitOfWorkRepository
{

    public readonly SalesDbContext _salesDbContext;

    public UnitOfWorkRepository(SalesDbContext salesDbContext, IUserRepository userRepository)
    {
        _salesDbContext = salesDbContext;
        UserRepository = userRepository;
    }

    public IUserRepository UserRepository { get; }

    public int Complete()
    {
        return _salesDbContext.SaveChanges();
    }

    public void Dispose()
    {
        _salesDbContext.Dispose();
    }
}
