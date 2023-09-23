using System;
using System.Collections.Generic;

namespace MVCNorthwind.Models;

public partial class SummaryOfSalesByQuarter
{
    public DateTime? ShippedDate { get; set; }

    public int OrderId { get; set; }

    public decimal? Subtotal { get; set; }
}
