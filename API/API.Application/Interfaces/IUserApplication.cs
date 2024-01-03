using API.Application.DataContract.Request.User;
using API.Domain.Models;
using API.Domain.Validations.Base;

namespace API.Application.Interfaces
{
    public interface IUserApplication
    {
        public Task<Response> Create(CreateUserRequest user);

        public Task<Response<List<UserModel>>> GetAll();

        public Task<Response<UserModel>> GetById(int id);

        public Task<Response> Update(CreateUserRequest user);

        public Task<Response> Delete(int id);
    }
}
