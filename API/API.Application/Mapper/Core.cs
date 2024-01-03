using API.Application.DataContract.Request.Profile;
using API.Application.DataContract.Request.User;
using API.Application.DataContract.Response.Profile;
using API.Application.DataContract.Response.User;
using API.Domain.Models;
using AutoMapper;

namespace API.Application.Mapper
{
    public class Core : Profile
    {
        public Core()
        {

        }

        private void UserMap()
        {
            CreateMap<CreateUserRequest, UserModel>();

            CreateMap<UserModel, UserResponse>();
        }

        private void ProfileMap()
        {
            CreateMap<CreateProfileRequest, ProfileModel>();

            CreateMap<ProfileModel, ProfileResponse>();
        }
    }
}
