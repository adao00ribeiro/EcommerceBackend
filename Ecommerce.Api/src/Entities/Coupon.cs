using Ecommerce.Api.src.Entities.Shared;

namespace Ecommerce.Api.src.Entities;

public class Coupon : Entity
{
    public string CouponCode { get; private set; }
    public decimal DiscountAmount { get; private set; }
    public Coupon(string couponCode, decimal discountAmount)
    {
        CouponCode = couponCode;
        DiscountAmount = discountAmount;
    }
}
