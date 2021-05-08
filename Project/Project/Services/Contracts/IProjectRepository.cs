using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Services.Contracts
{
    public interface IProjectRepository
    {
        Task<ToDo> CreateAsync(ToDo todo);
        Task<ToDoTask> CreateAsync(ToDoTask todoTask);
        Task<ToDoTask> GetToDoAsync(int todoId);
        Task<IEnumerable<ToDo>> GetToDoListAsync(int todoId);
        Task<IEnumerable<ToDoTask>> GetToDoTaskListAsync(int todoId);
    }
}
