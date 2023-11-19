using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class CourseEducator: IEntity
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int EducatorId { get; set; }
        public Course Course { get; set; }
        public Educator Educator { get; set; }
    }
}
