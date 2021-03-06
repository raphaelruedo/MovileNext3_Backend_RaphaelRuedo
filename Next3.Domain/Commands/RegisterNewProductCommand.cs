﻿using Next3.Domain.Validations;
using System;

namespace Next3.Domain.Commands
{
    public class RegisterNewProductCommand : ProductCommand
    {
        public RegisterNewProductCommand(string name, string description, decimal price, Guid restaurantId, Guid categoryId)
        {
            Name = name;
            Price = price;
            Description = description;
            RestaurantId = restaurantId;
            CategoryId = categoryId;

        }

        public override bool IsValid()
        {
            ValidationResult = new RegisterNewProductCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
