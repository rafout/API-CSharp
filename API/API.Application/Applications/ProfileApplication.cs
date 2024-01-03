using API.Application.DataContract.Request.Profile;
using API.Application.DataContract.Response.Profile;
using API.Application.Interfaces;
using API.Domain.Interfaces.Services;
using API.Domain.Models;
using API.Domain.Validations.Base;
using AutoMapper;

namespace API.Application.Applications
{
    public class ProfileApplication : IProfileApplication
    {
        private readonly IProfileService _profileService;
        private readonly IMapper _mapper;

        public ProfileApplication(IProfileService profileService, IMapper mapper)
        {
            _profileService = profileService;
            _mapper = mapper;
        }

        public async Task<Response> Create(CreateProfileRequest profile)
        {
            var profileModel = _mapper.Map<ProfileModel>(profile);
            return await _profileService.Create(profileModel);
        }

        public async Task<Response> Delete(int id)
        {
            return await _profileService.Delete(id);
        }

        public async Task<Response<List<ProfileModel>>> GetAll()
        {
            return await _profileService.GetAll();
        }

        public async Task<Response<ProfileModel>> GetById(int id)
        {
            return await _profileService.GetById(id);
        }

        public async Task<Response> Update(CreateProfileRequest profile)
        {
            ProfileModel profileModel = _mapper.Map<ProfileModel>(profile);
            return await _profileService.Update(profileModel);
        }

    }
}
