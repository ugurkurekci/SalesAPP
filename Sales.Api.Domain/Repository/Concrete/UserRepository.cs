using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Sales.Api.Domain.DataAccess;
using Sales.Api.Domain.Entity;
using Sales.Api.Domain.Repository.Abstract;
using System.Linq.Expressions;

namespace Sales.Api.Domain.Repository.Concrete;

public class UserRepository : IUserRepository
{

    private readonly SalesDbContext _context;
    private readonly IMapper _mapper;

    public UserRepository(SalesDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<IReadOnlyList<User>> GetAll()
    {
        return await _context.Set<User>().ProjectTo<User>(_mapper.ConfigurationProvider).ToListAsync();
    }

    public async Task<IReadOnlyList<User>> GetAllByFilter(Expression<Func<User, bool>> filter)
    {
        return await _context.Set<User>().ProjectTo<User>(_mapper.ConfigurationProvider).Where(filter).ToListAsync();
    }

    public async Task<User> GetByFilter(Expression<Func<User, bool>> filter)
    {
        return await _context.Set<User>().ProjectTo<User>(_mapper.ConfigurationProvider).FirstOrDefaultAsync(filter);
    }

    public Task Add(User entity)
    {
        _context.User.Add(entity);
        _context.SaveChanges();
        return Task.CompletedTask;

    }

    public Task Delete(User entity)
    {
        entity.IsDeleted = true;
        _context.User.Update(entity);
        _context.SaveChanges();
        return Task.CompletedTask;
    }

    public Task Update(User entity)
    {
        _context.User.Update(entity);
        _context.SaveChanges();
        return Task.CompletedTask;
    }

}