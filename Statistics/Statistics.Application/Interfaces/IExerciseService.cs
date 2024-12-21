using Statistics.Domain.Models;

namespace Statistics.Application.Interfaces
{
    public interface IExerciseService
    {
        Task<List<Exercise>> GetAll();
        Task<Exercise> Create(Exercise exercise);
        Task<Exercise> GetById(Guid id);
        Task<Exercise> Update(Guid id, Exercise exercise);
        Task Delete(Guid id);
    }
}
