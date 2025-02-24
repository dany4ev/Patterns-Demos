﻿using Patterns_Demo.Structural_Patterns.Decorator_Pattern.Models;

namespace Patterns_Demo.Structural_Patterns.Decorator_Pattern.Interfaces;

public abstract class OrderBase
{
    protected List<Product> products = new List<Product>
    {
        new Product {Name = "Phone", Price = 587},
        new Product {Name = "Tablet", Price = 800},
        new Product {Name = "PC", Price = 1200}
    };

    public abstract double CalculateTotalOrderPrice();
}