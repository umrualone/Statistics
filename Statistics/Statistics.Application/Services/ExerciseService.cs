using Statistics.Application.Interfaces;
using Statistics.Domain.Exceptions;
using Statistics.Domain.Interfaces;
using Statistics.Domain.Models;

namespace Statistics.Application.Services
{
    public class ExerciseService : IExerciseService
    {
        private readonly IExerciseRepository _repository;

        public ExerciseService(IExerciseRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Exercise>> GetAll()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Exercise> Create(Exercise exercise)
        {
            await _repository.AddAsync(exercise);
            return exercise;
        }

        public async Task<Exercise> GetById(Guid id)
        {
            var exercise = await _repository.GetByIdAsync(id);

            return exercise ?? throw new NotFoundException("Not founded");
        }

        public async Task<Exercise> Update(Guid id, Exercise exercise)
        {
            var existingExercise = await _repository.GetByIdAsync(id);

            if (existingExercise == null)
                throw new NotFoundException("Not founded");

            existingExercise.Title = exercise.Title;
            existingExercise.Count = exercise.Count;

            await _repository.Update(existingExercise);

            return existingExercise;
        }

        public async Task Delete(Guid id)
        {
            var exercise = await _repository.GetByIdAsync(id);

            if (exercise == null)
                throw new NotFoundException("Not founded");

            await _repository.Remove(exercise);
        }
    }
}
