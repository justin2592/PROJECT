using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class ToDo
    {
        [Key]
        public int id { get; set;  }
        public string Description { get; set; }
        public DateTime ToDoDate { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
