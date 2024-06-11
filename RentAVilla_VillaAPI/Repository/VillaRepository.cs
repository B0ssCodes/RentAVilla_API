using Microsoft.EntityFrameworkCore;
using RentAVilla_VillaAPI.Data;
using RentAVilla_VillaAPI.Models;
using RentAVilla_VillaAPI.Repository.RepositoryInterfaces;
using System.Linq;
using System.Linq.Expressions;

namespace RentAVilla_VillaAPI.Repository
{
    public class VillaRepository : Repository<Villa>, IVillaRepository
    {
        private readonly ApplicationDbContext _db;

        public VillaRepository(ApplicationDbContext db): base(db)
        {
            _db = db;
        }
        

        public async Task<Villa> UpdateAsync(Villa entity)
        {
            entity.UpdatedDate = DateTime.Now;
            _db.Villas.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
