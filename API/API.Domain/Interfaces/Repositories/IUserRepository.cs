using API.Domain.Models;

namespace API.Domain.Interfaces.Repositories
{
    public interface IUserRepository
    {
        Task Create(UserModel user);
        Task<List<UserModel>> GetAll();
        Task<UserModel> GetById(int id);
        Task<List<UserModel>> GetUsersWithFilters(string name, string username, string profile);
        Task Update(UserModel user);
        Task Delete(int id);
    }
}
