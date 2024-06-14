using RentAVilla_VillaAPI.Models;
using RentAVilla_VillaAPI.Models.Dto;

namespace RentAVilla_VillaAPI.Repository.RepositoryInterfaces
{
    public interface IUserRepository
    {
        bool IsUniqueUser(string username);
        Task<LoginResponseDTO> Login(LoginRequestDTO loginRequestDTO);
        Task<LocalUser> Register(RegistrationRequestDTO registrationRequestDTO);
    }
}
