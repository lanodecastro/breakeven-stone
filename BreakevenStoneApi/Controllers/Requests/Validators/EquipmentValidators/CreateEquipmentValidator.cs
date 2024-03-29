﻿using BreakevenStoneApi.Controllers.Requests.EquipmentRequest;
using FluentValidation;

namespace BreakevenStoneApi.Controllers.Requests.Validators.EquipmentValidators
{
    public class CreateEquipmentValidator : AbstractValidator<CreateEquipmentRequest>
    {
        public CreateEquipmentValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3);

            RuleFor(p => p.Description)
                .NotNull()
                .NotEmpty();
        }
    }
}
