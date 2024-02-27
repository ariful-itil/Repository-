using System;
using System.Collections.Generic;

namespace WebApplication1.ModelTest;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string CustomerName { get; set; } = null!;

    public string Email { get; set; } = null!;
}
