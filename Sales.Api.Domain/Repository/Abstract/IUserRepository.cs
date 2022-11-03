using Sales.Api.Domain.Entity;
using System.Linq.Expressions;

namespace Sales.Api.Domain.Repository.Abstract;

public interface IUserRepository
{
    Task<IReadOnlyList<User>> GetAll();

    Task<IReadOnlyList<User>> GetAllByFilter(Expression<Func<User, bool>> filter);

    Task<User> GetByFilter(Expression<Func<User, bool>> filter);

    Task Add(User entity);

    Task Update(User entity);

    Task Delete(User entity);

}