using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Educator: IEntity
    {
        public int EducatorId { get; set; }
        public string EducatorName { get; set; }
        public string ImageUrl { get; set; }
        public List<CourseEducator> CourseEducator { get; set; }
    }
}
