using Core.Utilities.Results.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICourseEducatorService
    {
        IResult Add(CourseEducator courseEducator);
        IResult Delete(CourseEducator courseEducator);
        IResult Update(CourseEducator courseEducator);
        IDataResult<List<CourseEducator>> GetAll();
        IDataResult<CourseEducator> GetById(int id);
        IDataResult<List<CourseEducator>> GetAllByCourseId(int id);
        IDataResult<List<CourseEducator>> GetAllByEducatorId(int id);
    }
}
