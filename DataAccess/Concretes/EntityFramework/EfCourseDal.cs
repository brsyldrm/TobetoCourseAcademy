using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using Entities.Concretes;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfCourseDal : EfEntityRepositoryBase<Course, TobetoCourseContext>, ICourseDal
    {
        public List<CourseDetailDto> GetCourseDetails()
        {
            using (TobetoCourseContext context = new TobetoCourseContext())
            {
                var result = from c in context.Courses
                             join cat in context.Categories
                             on c.CategoryID equals cat.Id
                             select new CourseDetailDto 
                             {Id=c.Id, Name=c.Name, CategoryName = cat.Name,Price = c.Price,Description=c.Description,ImageUrl=c.ImageUrl};
                return result.ToList();
            }
        }
    }
}
