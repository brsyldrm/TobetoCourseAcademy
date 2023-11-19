using Core.Utilities.Results.Abstracts;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICourseService
    {
        IDataResult<List<Course>> GetAll();
        IDataResult<Course> GetById(int id);
        IDataResult<List<Course>> GetAllByCategoryId(int id);
        IDataResult<List<Course>> GetAllByUnitPrice(double min, double max);
        IDataResult<List<CourseDetailDto>> GetCourseDetails();
        IResult Add(Course course);
        IResult Delete(Course course);
        IResult Update(Course course);
    }
}
