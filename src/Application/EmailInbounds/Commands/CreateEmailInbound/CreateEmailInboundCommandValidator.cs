using System;
using FluentValidation;

namespace GFCA.Application.EmailInbounds.Commands.CreateEmailInbound
{
    public class CreateEmailInboundCommandValidator : AbstractValidator<CreateEmailInboundCommand>
    {
        public CreateEmailInboundCommandValidator()
        {
            /*
            RuleFor(v => v.Remark).MaximumLength(200).NotEmpty();
            */
        }
    }

}
