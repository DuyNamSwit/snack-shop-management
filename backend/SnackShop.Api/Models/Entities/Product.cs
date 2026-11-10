using System;
using System.Collections.Generic;

namespace SnackShop.Api.Models.Entities;

public partial class Product
{
    public int Id { get; set; }

    public int? CategoryId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public decimal ImportPrice { get; set; }

    public decimal SellingPrice { get; set; }

    public int StockQuantity { get; set; }

    public string? ImageUrl { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedAt { get; set; }

    public decimal? DiscountPrice { get; set; }

    public decimal? DiscountPercent { get; set; }

    public virtual Category? Category { get; set; }

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}
