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

    public string GetUserLogin(UserLoginDto userLoginDto)
    {
        Task<User> getByID = GetByUsernameAndPassword(userLoginDto.Username, userLoginDto.Password);
        if (getByID == null)
        {
            return "Giriş doğrulanmadı.Bilgilerinizi kontrol edip tekrar deneyiniz.";
        }

        return "Giriş doğrulandı.";
    }

    public string GetUserRegister(UserRegisterDto userRegisterDto)
    {


        bool getByID = CheckByUsernameAndEmail(userRegisterDto.Username, userRegisterDto.Email);
        User usersModel = _mapper.Map<User>(userRegisterDto);
        if (getByID)
        {

            _unitOfWorkRepository.UserRepository.Add(usersModel);
            _unitOfWorkRepository.Complete();
        }

        return "Girdiğiniz EMail ve Kullanıcı Adı ile üyelik eşleşmektedir. Bilgilerinizi kontrol edip tekrar deneyiniz.";

    }

    private Task<User> GetByUsernameAndPassword(string username, string password)
    {
        return _unitOfWorkRepository.UserRepository.GetByFilter(x => x.Username == username && x.Password == password);
    }

    private bool CheckByUsernameAndEmail(string username, string email)
    {
        Task<User> getbyID = _unitOfWorkRepository.UserRepository.GetByFilter(x => x.Username == username || x.EMail == email);

        if (getbyID == null)
        {
            return true;
        }
        return false;

    }

}