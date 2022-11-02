using Sales.Api.Domain.Repository.Abstract;

namespace Sales.Api.Domain.Repository;

public interface IUnitOfWorkRepository : IDisposable
{

    public IUserRepository UserRepository { get; }

    public int Complete();

}