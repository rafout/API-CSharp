using API.Application.DataContract.Request.User;
using API.Application.Interfaces;
using API.Domain.Interfaces.Services;
using API.Domain.Models;
using API.Domain.Validations.Base;
using AutoMapper;

namespace API.Application.Applications
{
    public class UserApplication : IUserApplication
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserApplication(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        public async Task<Response> Create(CreateUserRequest user)
        {
            var userModel = _mapper.Map<UserModel>(user);
            return await _userService.Create(userModel);
        }

        public async Task<Response<List<UserModel>>> GetAll()
        {
            return await _userService.GetAll();
        }

        public async Task<Response<UserModel>> GetById(int id)
        {
            return await _userService.GetById(id);
        }

        public async Task<Response> Update(CreateUserRequest user)
        {
            var userModel = _mapper.Map<UserModel>(user);
            return await _userService.Update(userModel);
        }

        public async Task<Response> Delete(int id)
        {
            return await _userService.Delete(id);
        }
    }
}
