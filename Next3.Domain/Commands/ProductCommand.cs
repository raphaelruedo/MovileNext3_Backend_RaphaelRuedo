﻿using Next3.Domain.Core.Commands;
using System;

namespace Next3.Domain.Commands
{
    public abstract class ProductCommand : Command
    {
        public Guid Id { get; protected set; }

        public string Name { get; protected set; }

        public string Description { get; protected set; }

        public decimal Price { get; protected set; }

        public Guid RestaurantId { get; set; }

        public Guid CategoryId { get; set; }
    }
}
