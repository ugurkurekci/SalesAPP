using Sales.Api.Business.Dto;

namespace Sales.Api.Business.Services.Abstract;

public interface IUserService
{

    Task<Result> GetUserRegister(UserRegisterDto userRegisterDto);

    Task<Result> GetUserLogin(UserLoginDto userLoginDto);

}