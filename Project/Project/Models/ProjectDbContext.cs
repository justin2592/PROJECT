using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Project.Models
{
    public class ProjectDbContext : DbContext
    {
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options)
        { }
        public DbSet<ToDo> ToDos { get; set; }
        public DbSet<ToDoTask> ToDoTasks { get; set; }
    }
}
