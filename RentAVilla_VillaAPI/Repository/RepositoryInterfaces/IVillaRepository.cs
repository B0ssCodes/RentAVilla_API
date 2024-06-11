using RentAVilla_VillaAPI.Models;
using System.Linq.Expressions;

namespace RentAVilla_VillaAPI.Repository.RepositoryInterfaces
{
    public interface IVillaRepository : IRepository<Villa>
    {
        
        Task<Villa> UpdateAsync(Villa entity);
        
    }
}
