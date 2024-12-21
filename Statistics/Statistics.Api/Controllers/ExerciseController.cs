using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Statistics.Application.Dtos.Requests.Exersice;
using Statistics.Application.Dtos.Resources.Exersice;
using Statistics.Application.Dtos.Responces;
using Statistics.Application.Interfaces;
using Statistics.Domain.Models;

namespace Statistics.Api.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ExerciseController : ControllerBase
    {
        private readonly IExerciseService _exerciseService;
        private readonly IMapper _mapper;

        public ExerciseController(IExerciseService exerciseService, IMapper mapper)
        {
            _exerciseService = exerciseService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var exercises = await _exerciseService.GetAll();

            return Ok(exercises);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ExersiceCreateRequest request)
        {
            var exercise = _mapper.Map<Exercise>(request);
            exercise = await _exerciseService.Create(exercise);

            var response = new SuccessResponse<ExersiceFullResources>(
                "ok", 
                200,
                _mapper.Map<ExersiceFullResources>(exercise)
            );

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var exercise = await _exerciseService.GetById(id);

            return Ok(exercise);
        }
    }
}
