using Microsoft.EntityFrameworkCore;
using Statistics.Domain.Interfaces;
using Statistics.Domain.Models;
using Statistics.Infrastructure.Data;

namespace Statistics.Infrastructure.Repositories
{
    public class GenericRepository<TModel> : IGenericRepository<TModel> where TModel : BaseModel
    {
        private readonly AppDbContext _context;
        private readonly DbSet<TModel> _dataBase;

        public GenericRepository(AppDbContext context)
        {
            _context = context;
            _dataBase = context.Set<TModel>();
        }

        public async Task<List<TModel>> GetAllAsync()
        {
            return await _dataBase.ToListAsync();
        }

        public async Task<TModel> GetByIdAsync(Guid id)
        {
            return await _dataBase.FindAsync(id);
        }

        public async Task AddAsync(TModel model)
        {
            await _dataBase.AddAsync(model);
            await _context.SaveChangesAsync();
        }

        public async Task Update(TModel model)
        {
            _dataBase.Update(model);
            await _context.SaveChangesAsync();
        }

        public async Task Remove(TModel model)
        {
            _dataBase.Remove(model);
            await _context.SaveChangesAsync();
        }
    }
}
