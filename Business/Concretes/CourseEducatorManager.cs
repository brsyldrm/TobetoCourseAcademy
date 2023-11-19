using Business.Abstracts;
using Business.Contants;
using Core.Utilities.Results.Abstracts;
using Core.Utilities.Results.Concretes;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CourseEducatorManager : ICourseEducatorService
    {
        ICourseEducatorDal _icourseEducationDal;

        public CourseEducatorManager(ICourseEducatorDal icourseEducationDal)
        {
            _icourseEducationDal = icourseEducationDal;
        }

        public IResult Add(CourseEducator courseEducator)
        {
            _icourseEducationDal.Add(courseEducator);
            return new SuccessResult(Messages.CourseAdded);
        }

        public IResult Delete(CourseEducator courseEducator)
        {
            _icourseEducationDal.Delete(courseEducator);
            return new SuccessResult(Messages.CourseDeleted);
        }

        public IDataResult<List<CourseEducator>> GetAll()
        {
            return new SuccessDataResult<List<CourseEducator>>(_icourseEducationDal.GetAll());
        }

        public IDataResult<List<CourseEducator>> GetAllByCourseId(int id)
        {
            return new SuccessDataResult<List<CourseEducator>>(_icourseEducationDal.GetAll(p=>p.CourseId==id));
        }

        public IDataResult<List<CourseEducator>> GetAllByEducatorId(int id)
        {
            return new SuccessDataResult<List<CourseEducator>>(_icourseEducationDal.GetAll(p => p.EducatorId == id));
        }

        public IDataResult<CourseEducator> GetById(int id)
        {
            return new SuccessDataResult<CourseEducator>(_icourseEducationDal.Get(p=>p.Id==id));
        }

        public IResult Update(CourseEducator courseEducator)
        {
            _icourseEducationDal.Update(courseEducator);
            return new SuccessResult(Messages.CourseUpdated);
        }
    }
}
