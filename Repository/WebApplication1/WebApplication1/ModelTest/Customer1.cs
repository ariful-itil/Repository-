using System;
using System.Collections.Generic;

namespace WebApplication1.ModelTest;

public partial class Customer1
{
    public int CustomerId { get; set; }

    public string CustomerName { get; set; } = null!;

    public string CustomerEmail { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
