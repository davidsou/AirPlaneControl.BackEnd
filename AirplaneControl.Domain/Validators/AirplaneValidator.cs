using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirplaneControl.Domain.Validators
{
    public class AirPlaneValidator : AbstractValidator<Airplane>
    {
        public const string RequiredName = "Name is mandatory";
        public const string RequiredQuantity = "Quantity of Seats is mandatory";
        public AirPlaneValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage(RequiredName);

            RuleFor(x => x.QuantityOfSeats)
                .LessThanOrEqualTo(0)
                .WithMessage(RequiredQuantity);
        }
    }
}
