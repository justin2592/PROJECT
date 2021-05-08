using Microsoft.EntityFrameworkCore;
using Project.Models;
using Project.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Services.Concretes
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly ProjectDbContext _projectDbContext;
        public ProjectRepository(ProjectDbContext projectDbContext)
        {
            _projectDbContext = projectDbContext;
        }
        public async Task<ToDo> CreateAsync(ToDo toDo)
        {
            _projectDbContext.ToDos.Add(toDo);
            await _projectDbContext.SaveChangesAsync();

            return toDo;
        }
        public async Task<ToDoTask> CreateAsync(ToDoTask toDoTask)
        {
            _projectDbContext.ToDoTasks.Add(toDoTask);
            await _projectDbContext.SaveChangesAsync();

            return toDoTask;
        }
        public async Task<IEnumerable<ToDoTask>> GetToDoTaskListAsync(int todoId)
        {
            return await _projectDbContext.ToDoTasks.ToListAsync();
        }
        public async Task<IEnumerable<ToDo>> GetToDoListAsync(int todoId)
        {
            return await _projectDbContext.ToDos.ToListAsync();
        }
        public async Task<ToDoTask> GetToDoAsync(int todoId)
        {
            return await _projectDbContext.ToDoTasks.SingleOrDefaultAsync();
        }
    }
}
