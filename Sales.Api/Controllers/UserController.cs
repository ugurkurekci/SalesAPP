using Microsoft.AspNetCore.Mvc;
using Sales.Api.Business.Dto;
using Sales.Api.Business.Services.Abstract;

namespace Sales.Api.Controllers;

public class UserController : BaseController
{

    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost("Login")]
    public async Task<IActionResult> Login(UserLoginDto userLoginDto)
    {

        Result result = await _userService.GetUserLogin(userLoginDto);
        if (result.Success == true)
        {
            return Ok(result);
        }

        return BadRequest(result.Message);

    }
    [HttpPost("Register")]
    public async Task<IActionResult> Register(UserRegisterDto userRegisterDto)
    {

        Result result = await _userService.GetUserRegister(userRegisterDto);
        if (result.Success == true)
        {
            return Ok(result);
        }

        return BadRequest(result.Message);

    }

}