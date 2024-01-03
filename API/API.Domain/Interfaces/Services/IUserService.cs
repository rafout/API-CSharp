using API.Domain.Models;
using API.Domain.Validations.Base;

namespace API.Domain.Interfaces.Services
{
    public interface IUserService
    {
        Task<Response<bool>> Authentication(string username, string password);
        Task<Response> Create(UserModel user);
        Task<Response<List<UserModel>>> GetAll();
        Task<Response<UserModel>> GetById(int id);
        Task<Response<List<UserModel>>> GetUsersWithFilters(string name, string username, string profile);
        Task<Response> Update(UserModel user);
        Task<Response> Delete(int id);
    }
}
