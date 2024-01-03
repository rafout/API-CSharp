using API.Domain.Interfaces.Repositories;
using API.Domain.Interfaces.Services;
using API.Domain.Models;
using API.Domain.Validations.Base;
using API.Domain.Validations;
using static System.Runtime.InteropServices.JavaScript.JSType;
using FluentValidation;

namespace API.Domain.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public Task<Response<bool>> Authentication(string username, string password)
        {
            throw new NotImplementedException();
        }

        async public Task<Response> Create(UserModel user)
        {
            Response response = new Response();

            UserValidation validation = new UserValidation();
            Response errors = validation.Validate(user).GetErrors();

            if (errors.Report.Count > 0)
                return errors;

            await _userRepository.Create(user);
            return response;
        }

        public async Task<Response> Delete(int id)
        {
            Response response = new Response();

            UserModel exists = await _userRepository.GetById(id);

            if(exists == null)
            {
                response.Report.Add(Report.Create($"Usuário {id} não existe"));
                return response;
            }

            await _userRepository.Delete(id);
            return response;
        }

        public async Task<Response<List<UserModel>>> GetAll()
        {
            Response<List<UserModel>> response = new Response<List<UserModel>>();

            List<UserModel> users = await _userRepository.GetAll();

            if (users.Count == 0)
            {
                response.Report.Add(Report.Create($"Não existem usuários cadastrados"));
                return response;
            }

            response.Data = users;
            return response;
        }

        public async Task<Response<UserModel>> GetById(int id)
        {
            Response<UserModel> response = new Response<UserModel>();

            UserModel user = await _userRepository.GetById(id);

            if (user == null)
            {
                response.Report.Add(Report.Create($"Usuário {id} não existe"));
                return response;
            }

            response.Data = user;
            return response;
        }

        public async Task<Response<List<UserModel>>> GetUsersWithFilters(string name, string username, string profile)
        {
            Response<List<UserModel>> response = new Response<List<UserModel>>();

            List<UserModel> users = await _userRepository.GetUsersWithFilters(name, username, profile);

            if (users.Count == 0)
            {
                response.Report.Add(Report.Create($"Não existem usuários cadastrados"));
                return response;
            }

            response.Data = users;
            return response;
        }

        public async Task<Response> Update(UserModel user)
        {
            Response response = new Response();

            UserValidation validation = new UserValidation();
            Response errors = validation.Validate(user).GetErrors();

            if (errors.Report.Count > 0)
                return errors;

            UserModel exists = await _userRepository.GetById(user.Id);
            if (exists == null)
            {
                response.Report.Add(Report.Create($"Usuário {user.Id} não existe"));
                return response;
            }

            await _userRepository.Update(user);
            return response;
        }
    }
}
