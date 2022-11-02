using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Sales.Api.Business.Services.Abstract;
using Sales.Api.Business.Services.Concrete;
using Sales.Api.Domain.DataAccess;
using Sales.Api.Domain.Repository;
using Sales.Api.Domain.Repository.Abstract;
using Sales.Api.Domain.Repository.Concrete;
using System.Reflection;

namespace Sales.Api.Business;

public static class ServiceProvider
{
    public static void MyDependencyInjections(this IServiceCollection services)
    {

        // DbContext
        services.AddTransient<SalesDbContext>();


        // AutoMapper
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        //AutoMapperExtensions

        //AutoMappers
        services.AddMediatR(typeof(IAssemblyMarker).Assembly);

        // Repositories

        services.AddScoped<IUnitOfWorkRepository, UnitOfWorkRepository>();

        services.AddScoped<IUserRepository, UserRepository>();

        // Services

        services.AddScoped<IUserService, UserService>();


    }

}