using RentAVilla_VillaAPI.Models;

namespace RentAVilla_VillaAPI.Repository.RepositoryInterfaces
{
    public interface IVillaNumberRepository : IRepository<VillaNumber>
    {
        Task<VillaNumber> UpdateAsync(VillaNumber entity);
    }
}
