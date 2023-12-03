using Entities.Concretes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class EducatorValidator:AbstractValidator<Educator>
    {
        public EducatorValidator()
        {
            RuleFor(c=>c.EducatorName).NotEmpty();
            RuleFor(c => c.EducatorName).MinimumLength(2);
        }
    }
}
