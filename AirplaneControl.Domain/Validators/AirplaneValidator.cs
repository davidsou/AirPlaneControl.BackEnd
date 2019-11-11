using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirplaneControl.Domain.Validators
{
    public class AirPlaneValidator : AbstractValidator<AirPlane>
    {
        public const string RequiredName = "Name is mandatory";
        public const string RequiredQuantity = "Quantity of Seats is mandatory";
        public AirPlaneValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage(RequiredName);

            RuleFor(x => x.QuantityOfSeats)
                .GreaterThan(0)
                .WithMessage(RequiredQuantity);
        }
    }
}
