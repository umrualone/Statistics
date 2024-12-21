using Statistics.Domain.Models;

namespace Statistics.Domain.Interfaces
{
    public interface IGenericRepository<TModel> where TModel : BaseModel
    {
        Task<List<TModel>> GetAllAsync();
        Task<TModel> GetByIdAsync(Guid id);
        Task AddAsync(TModel model);
        Task Update(TModel model);
        Task Remove(TModel model);
    }
}
