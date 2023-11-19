using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    public class TobetoCourseContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-0CHTP41A\SQLEXPRESS;Database=TobetoCourse;Trusted_Connection=true;TrustServerCertificate=True;");
        }
       
        public DbSet<Course> Courses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Educator> Educators { get; set; }
        public DbSet<CourseEducator> CourseEducators { get; set; }
    }
}
