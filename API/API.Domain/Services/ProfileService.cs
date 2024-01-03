using API.Domain.Interfaces.Repositories;
using API.Domain.Interfaces.Services;
using API.Domain.Models;
using API.Domain.Validations;
using API.Domain.Validations.Base;

namespace API.Domain.Services
{
    public class ProfileService : IProfileService
    {
        private readonly IProfileRepository _profileRepository;
        public ProfileService(IProfileRepository profileRepository)
        {
            _profileRepository = profileRepository;
        }

         public async Task<Response> Create(ProfileModel profile)
        {
            Response response = new Response();

            ProfileValidation validation = new ProfileValidation();
            Response errors = validation.Validate(profile).GetErrors();

            if (errors.Report.Count > 0)
                return errors;

            await _profileRepository.Create(profile);

            return response;
        }

        public async Task<Response> Delete(int id)
        {
            Response response = new Response();

            ProfileModel exists = await _profileRepository.GetById(id);

            if (exists == null)
            {
                response.Report.Add(Report.Create($"Perfil {id} não existe"));
                return response;
            }

            await _profileRepository.Delete(id);
            return response;
        }

        public async Task<Response<List<ProfileModel>>> GetAll()
        {
            Response<List<ProfileModel>> response = new Response<List<ProfileModel>>();

            List<ProfileModel> profiles = await _profileRepository.GetAll();

            if (profiles.Count == 0)
            {
                response.Report.Add(Report.Create($"Não existem perfis cadastrados"));
                return response;
            }

            response.Data = profiles;
            return response;
        }

        public async Task<Response<ProfileModel>> GetById(int id)
        {
            Response<ProfileModel> response = new Response<ProfileModel>();

            ProfileModel exists = await _profileRepository.GetById(id);
            if (exists == null)
            {
                response.Report.Add(Report.Create($"Perfil {id} não existe"));
                return response;
            }

            ProfileModel data = await _profileRepository.GetById(id);
            response.Data = data;
            return response;
        }

        public async Task<Response<List<ProfileModel>>> GetProfilesWithFilters(string name)
        {
            Response<List<ProfileModel>> response = new Response<List<ProfileModel>>();

            List<ProfileModel> profiles = await _profileRepository.GetProfilesWithFilters(name);

            if (profiles.Count == 0)
            {
                response.Report.Add(Report.Create($"Não existem perfis cadastrados com esse nome"));
                return response;
            }

            response.Data = profiles;
            return response;
        }

        public async Task<Response> Update(ProfileModel profile)
        {
            Response response = new Response();

            ProfileValidation validation = new ProfileValidation();
            Response errors = validation.Validate(profile).GetErrors();

            if (errors.Report.Count > 0)
                return errors;

            ProfileModel exists = await _profileRepository.GetById(profile.Id);
            if (exists == null)
            {
                response.Report.Add(Report.Create($"Perfil {profile.Id} não existe"));
                return response;
            }

            await _profileRepository.Update(profile);
            return response;
        }
    }
}
