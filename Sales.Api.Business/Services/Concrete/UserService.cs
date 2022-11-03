using AutoMapper;
using Sales.Api.Business.Dto;
using Sales.Api.Business.Services.Abstract;
using Sales.Api.Domain.Entity;
using Sales.Api.Domain.Repository;

namespace Sales.Api.Business.Services.Concrete;

public class UserService : IUserService
{

    private readonly IUnitOfWorkRepository _unitOfWorkRepository;
    private readonly IMapper _mapper;

    public UserService(IUnitOfWorkRepository unitOfWorkRepository, IMapper mapper)
    {
        _unitOfWorkRepository = unitOfWorkRepository;
        _mapper = mapper;
    }

    public async Task<Result> GetUserLogin(UserLoginDto userLoginDto)
    {
        var getByID = await GetByUsernameAndPassword(userLoginDto.Username, userLoginDto.Password);
        if (getByID == null)
        {
            return new Result
            {
                Message = "Giriş doğrulanmadı.Bilgilerinizi kontrol edip tekrar deneyiniz.",
                Data = userLoginDto,
                Success = false
            };
        }

        return new Result
        {
            Message = "Giriş doğrulandı",
            Data = userLoginDto,
            Success = true
        };
    }

    public async Task<Result> GetUserRegister(UserRegisterDto userRegisterDto)
    {
        User usersModel = _mapper.Map<User>(userRegisterDto);

        User getByID = await CheckByUsernameAndEmail(usersModel.Username, usersModel.EMail);
        if (getByID == null)
        {

            await _unitOfWorkRepository.UserRepository.Add(usersModel);
            return new Result
            {
                Message = "Kayıt başarıyla gerçekleştirildi.",
                Data = userRegisterDto,
                Success = true
            };
        }

        return new Result
        {
            Message = "Kayıt doğrulanmadı.Bilgilerinizi kontrol edip tekrar deneyiniz.",
            Data = "[]",
            Success = false
        };

    }

    private async Task<User> GetByUsernameAndPassword(string username, string password)
    {
        return await _unitOfWorkRepository.UserRepository.GetByFilter(x => x.Username == username && x.Password == password);
    }

    private async Task<User> CheckByUsernameAndEmail(string username, string email)
    {
        User getbyID = await _unitOfWorkRepository.UserRepository.GetByFilter(x => x.Username == username || x.EMail == email);
        return getbyID;
    }

}