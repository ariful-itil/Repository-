using System;
using System.Collections.Generic;

namespace WebApplication1.ModelTest;

public partial class Product
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public DateTime MfgDate { get; set; }

    public bool Avaliable { get; set; }

    public int CustomerId { get; set; }

    public virtual Customer1 Customer { get; set; } = null!;
}
