using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Bootcamp> Bootcamps => Set<Bootcamp>();
        public DbSet<Student> Students => Set<Student>();
        public DbSet<RegisteredUsers> RegisteredUsers => Set<RegisteredUsers>();

        public DbSet<Teacher> Teachers => Set<Teacher>();


    }
}