using System.Linq.Expressions;

namespace Sales.Api.Domain.Repository.GenericBaseRepository;

public interface IRepositoryBase<TSource> where TSource : class
{

    Task<IReadOnlyList<TSource>> GetAll();

    Task<IReadOnlyList<TSource>> GetAllByFilter(Expression<Func<TSource, bool>> filter);

    Task<TSource> GetByFilter(Expression<Func<TSource, bool>> filter);

    Task Add(TSource entity);

    Task Update(TSource entity);

    Task Delete(TSource entity);

}