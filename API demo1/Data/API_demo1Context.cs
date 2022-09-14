using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using API_demo1.Model;

namespace API_demo1.Data
{
    public class API_demo1Context : DbContext
    {
        public API_demo1Context (DbContextOptions<API_demo1Context> options)
            : base(options)
        {
        }

        public DbSet<API_demo1.Model.User> User { get; set; } = default!;
    }
}
