using Core.Utilities.Results.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IEducatorService
    {
        IResult Add(Educator educator);
        IResult Delete(Educator educator);
        IResult Update(Educator educator);
        IDataResult<List<Educator>> GetAll();
        IDataResult<List<Educator>> GetById(int id);
    }
}
