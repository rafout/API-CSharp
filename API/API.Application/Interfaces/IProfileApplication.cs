
using API.Application.DataContract.Request.Profile;
using API.Application.DataContract.Response.Profile;
using API.Domain.Models;
using API.Domain.Validations.Base;

namespace API.Application.Interfaces
{
    public interface IProfileApplication
    {
        public Task<Response> Create(CreateProfileRequest profile);

        public Task<Response<List<ProfileModel>>> GetAll();

        public Task<Response<ProfileModel>> GetById(int id);

        public Task<Response> Update(CreateProfileRequest profile);

        public Task<Response> Delete(int id);
    }
}
