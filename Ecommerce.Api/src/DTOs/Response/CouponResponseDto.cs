using Ecommerce.Api.src.Entities;

namespace Ecommerce.Api.src.DTOs.Response;

public record CouponResponseDto(string CouponCode , decimal DiscountAmount)
{
    internal static CouponResponseDto ConvertToDto(Coupon coupon)
    {
        return new CouponResponseDto(coupon.CouponCode , coupon.DiscountAmount);
    }
}
