using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Sales.Api.Domain.Repository.GenericBaseRepository;

public class RepositoryBase<TSource> : IRepositoryBase<TSource> where TSource : class
{
    protected DbContext ProjectDbContext;
    protected readonly DbSet<TSource> DbSet;
    protected readonly IMapper Mapper;

    public RepositoryBase(DbContext context, IMapper mapper)
    {
        ProjectDbContext = context;
        DbSet = ProjectDbContext.Set<TSource>();
        Mapper = mapper;
    }

    public async Task<IReadOnlyList<TSource>> GetAll()
    {
        return await ProjectDbContext.Set<TSource>().ProjectTo<TSource>(Mapper.ConfigurationProvider).ToListAsync();
    }

    public async Task<IReadOnlyList<TSource>> GetAllByFilter(Expression<Func<TSource, bool>> filter)
    {
        return await ProjectDbContext.Set<TSource>().ProjectTo<TSource>(Mapper.ConfigurationProvider).Where(filter).ToListAsync();
    }

    public async Task<TSource> GetByFilter(Expression<Func<TSource, bool>> filter)
    {
        return await ProjectDbContext.Set<TSource>().ProjectTo<TSource>(Mapper.ConfigurationProvider).FirstOrDefaultAsync(filter);
    }

    public async Task Add(TSource entity)
    {
        await DbSet.AddAsync(entity);
    }

    public async Task Update(TSource entity)
    {
        DbSet.Update(entity);
        await Task.CompletedTask;
    }

    public async Task Delete(TSource entity)
    {
        DbSet.Update(entity);
        await Task.CompletedTask;

    }

}
