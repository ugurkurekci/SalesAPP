using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Sales.Api.Domain.Entity;
using Sales.Api.Domain.Repository.Abstract;
using Sales.Api.Domain.Repository.GenericBaseRepository;

namespace Sales.Api.Domain.Repository.Concrete;

public class UserRepository : RepositoryBase<User>, IUserRepository
{
    public UserRepository(DbContext context, IMapper mapper) : base(context, mapper)
    {
    }
}