using System;
using System.Collections.Generic;

namespace SnackShop.Api.Models.Entities;

public partial class Order
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public string CustomerName { get; set; } = null!;

    public string CustomerPhone { get; set; } = null!;

    public string CustomerAddress { get; set; } = null!;

    public string? Note { get; set; }

    public decimal TotalAmount { get; set; }

    public string? Status { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual User? User { get; set; }
}
