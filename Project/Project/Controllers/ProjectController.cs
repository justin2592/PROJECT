using Microsoft.AspNetCore.Mvc;
using Project.Models;
using Project.Services.Contracts;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Controllers
{
    [Route("api/Project")]
    [ApiController]
    public class ProjectController : Controller
    {
        private readonly IProjectRepository _projectRepository;
        public ProjectController(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }
        [SwaggerOperation(Summary = "Get Todo Records")]
        [HttpPost("MyApi/ToDo/create")]
        public async Task<IActionResult> CreateToDo([FromBody] ToDo toDo)
        {
            try
            {
                toDo.DateCreated = DateTime.Now;
                await _projectRepository.CreateAsync(toDo);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }
        [SwaggerOperation(Summary = "Create Task Records")]
        [HttpPost("MyApi/ToDoTask/create")]
        public async Task<IActionResult> CreateToDoTask([FromBody] ToDoTask toDoTask)
        {
            try
            {
                await _projectRepository.CreateAsync(toDoTask);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }
        [SwaggerOperation(Summary = "Get ToDo List")]
        [HttpGet("MyApi/ToDoTaskList/Get")]
        public async Task<IActionResult> GetToDoTaskListAsync(int toDoId)
        {
            try
            {
                var result = await _projectRepository.GetToDoTaskListAsync(toDoId);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }
    }
}
