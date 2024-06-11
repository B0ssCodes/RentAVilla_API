using Microsoft.EntityFrameworkCore.Internal;
using RentAVilla_VillaAPI.Data;
using RentAVilla_VillaAPI.Models;
using RentAVilla_VillaAPI.Repository.RepositoryInterfaces;
using System.Linq.Expressions;

namespace RentAVilla_VillaAPI.Repository
{
    public class VillaNumberRepository : Repository<VillaNumber>, IVillaNumberRepository
    {
        private readonly ApplicationDbContext _db;

        public VillaNumberRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<VillaNumber> UpdateAsync(VillaNumber entity)
        {
            entity.UpdatedDate = DateTime.Now;
            _db.VillaNumbers.Update(entity);
           await _db.SaveChangesAsync();
            return entity; ;
        }
    }
}

