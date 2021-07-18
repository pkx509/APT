using System;
using FluentValidation;
using GFCA.Shared.Models.Dto;

namespace GFCA.WebUI.Pages.Masters.Accountants.GLAccounts
{
    public class GLGroupValidator : AbstractValidator<GLGroupDto?>
    {
        public GLGroupValidator()
        {
            //RuleFor(x => x!.GroupName).NotEmpty().When(x => x != null).WithMessage("GroupName is not null");
            //RuleFor(x => x!.GroupPolicy).NotEmpty().When(x => x != null).WithMessage("GroupPolicy is not null");

            RuleFor(x => x!.GroupName).NotEmpty().WithMessage("GroupName is not null");
            RuleFor(x => x!.GroupPolicy).NotEmpty().WithMessage("GroupPolicy is not null");
        }
    }
}
