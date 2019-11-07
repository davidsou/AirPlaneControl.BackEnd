using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirplaneControl.Domain.Validators
{
   public class PassengerValidator: AbstractValidator<Passenger>
    {
        public const string RequiredName = "Name is mandatory";
        public PassengerValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage(RequiredName);

        }
    }
}
