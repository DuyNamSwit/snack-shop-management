using System;
using System.Collections.Generic;

namespace SnackShop.Api.Models.Entities;

public partial class Expense
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public decimal Amount { get; set; }

    public DateOnly? ExpenseDate { get; set; }

    public string? Note { get; set; }
}
