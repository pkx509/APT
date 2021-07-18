using System;
using System.Diagnostics.CodeAnalysis;
using FluentValidation;
using FluentValidation.Results;
using GFCA.Shared.Models.Dto;

namespace GFCA.WebUI.Pages.Masters.Accountants.GLAccounts
{
    public class GLAccountValidator : AbstractValidator<GLAccountDto>
    {
        public GLAccountValidator()
        {
            RuleFor(p => p.GLCode).NotEmpty().WithMessage("GLCode is required");
            RuleFor(p => p.GLName).NotEmpty().WithMessage("GLName is required");
            //RuleFor(p => p.GLGroup).SetValidator(new GLGroupValidator());
        }
    }
}
