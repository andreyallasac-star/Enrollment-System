using System;

namespace Model
{
    public class Discount
    {
        public int DiscountId { get; set; }
        public string DiscountName { get; set; }
        public decimal DiscountPercent { get; set; }
        public bool IsActive { get; set; }

        public string DisplayText => DiscountPercent > 0
            ? $"{DiscountName} ({DiscountPercent:0.##}%)"
            : DiscountName;
    }
}