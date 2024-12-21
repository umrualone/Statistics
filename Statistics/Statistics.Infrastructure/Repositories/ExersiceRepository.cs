using Statistics.Domain.Interfaces;
using Statistics.Domain.Models;
using Statistics.Infrastructure.Data;

namespace Statistics.Infrastructure.Repositories
{
    public class ExerciseRepository : GenericRepository<Exercise>, IExerciseRepository
    {
        public ExerciseRepository(AppDbContext context) : base(context)
        {
        }
    }
}
