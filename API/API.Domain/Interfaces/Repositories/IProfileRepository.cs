using API.Domain.Models;

namespace API.Domain.Interfaces.Repositories
{
    public interface IProfileRepository
    {
        Task Create(ProfileModel user);
        Task<List<ProfileModel>> GetAll();
        Task<ProfileModel> GetById(int id);
        Task<List<ProfileModel>> GetProfilesWithFilters(string name);
        Task Update(ProfileModel user);
        Task Delete(int id);
    }
}
