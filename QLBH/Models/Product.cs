﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLBH.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public decimal Price { get; set; }

    public List<string> ImagePath { get; set; } = new List<string>();

    public int CategoryId { get; set; }

    public int Stock { get; set; }

    public bool Deleted { get; set; }

    [ValidateNever]
    public virtual Category Category { get; set; } = null!;
}
