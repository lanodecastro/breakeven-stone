﻿using BreakevenStoneApi.Controllers.Requests.ProductRequests;
using FluentValidation;

namespace BreakevenStoneApi.Controllers.Requests.Validators.ProductValidators
{
    public class CreateProductValidator : AbstractValidator<ProductRequest>
    {
        public CreateProductValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty()
                .NotNull()
                .MinimumLength(2);

            RuleFor(p => p.Price)
                .NotNull()
                .NotEmpty();
        }
    }
}
