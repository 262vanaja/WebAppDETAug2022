using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TodoAPi.Models;

namespace ToDoAPI11.Data
{
    public class ToDoAPI11Context : DbContext
    {
        public ToDoAPI11Context (DbContextOptions<ToDoAPI11Context> options)
            : base(options)
        {
        }

        public DbSet<TodoAPi.Models.TodoItem> TodoItem { get; set; } = default!;
    }
}
