using Business.Abstracts;
using Business.Contants;
using Core.Utilities.Results.Abstracts;
using Core.Utilities.Results.Concretes;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class EducatorManager : IEducatorService
    {
        IEducatorDal _educationDal;

        public EducatorManager(IEducatorDal educationDal)
        {
            _educationDal = educationDal;
        }

        public IResult Add(Educator educator)
        {
            _educationDal.Add(educator);
            return new SuccessResult(Messages.EducatorAdded);
        }

        public IResult Delete(Educator educator)
        {
            _educationDal.Delete(educator);
            return new SuccessResult(Messages.EducatorDeleted);
        }

        public IDataResult<List<Educator>> GetAll()
        {
            return new SuccessDataResult<List<Educator>>(_educationDal.GetAll(),Messages.EducatorListed);
        }

        public IDataResult<List<Educator>> GetById(int id)
        {
            return new SuccessDataResult<List<Educator>>(_educationDal.GetAll(p => p.EducatorId == id),Messages.EducatorListed);
        }

        public IResult Update(Educator educator)
        {
            _educationDal.Update(educator);
            return new SuccessResult(Messages.EducatorUpdated);
        }
    }
}
