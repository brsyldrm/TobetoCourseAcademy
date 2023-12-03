using Entities.Concretes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CourseValidator:AbstractValidator<Course>
    {
        public CourseValidator()
        {
            RuleFor(c => c.Name).NotEmpty();
            RuleFor(c => c.Name).MinimumLength(2);
            RuleFor(c => c.Price).NotEmpty();
            RuleFor(p => p.Price).GreaterThanOrEqualTo(1);
        }
    }
}
