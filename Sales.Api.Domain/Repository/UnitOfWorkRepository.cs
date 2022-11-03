using Sales.Api.Domain.DataAccess;
using Sales.Api.Domain.Repository.Abstract;

namespace Sales.Api.Domain.Repository;

public class UnitOfWorkRepository : IUnitOfWorkRepository
{

    private readonly SalesDbContext _context;

    public UnitOfWorkRepository(IUserRepository userRepository, SalesDbContext context)
    {
        UserRepository = userRepository;
        _context = context;
    }

    public IUserRepository UserRepository { get; }

    public void Dispose()
    {
        _context.Dispose();
    }

}