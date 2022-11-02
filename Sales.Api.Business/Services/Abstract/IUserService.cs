using Sales.Api.Business.Dto;

namespace Sales.Api.Business.Services.Abstract;

public interface IUserService
{

    string GetUserRegister(UserRegisterDto userRegisterDto);

    string GetUserLogin(UserLoginDto userLoginDto);

}