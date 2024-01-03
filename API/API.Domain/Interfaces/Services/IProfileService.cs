using API.Domain.Models;
using API.Domain.Validations.Base;

namespace API.Domain.Interfaces.Services
{
    public interface IProfileService
    {
        Task<Response> Create(ProfileModel user);
        Task<Response<List<ProfileModel>>> GetAll();
        Task<Response<ProfileModel>> GetById(int id);
        Task<Response<List<ProfileModel>>> GetProfilesWithFilters(string name);
        Task<Response> Update(ProfileModel user);
        Task<Response> Delete(int id);
    }
}
