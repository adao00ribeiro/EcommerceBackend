using Ecommerce.Api.src.Entities;

namespace Ecommerce.Api.src.DTOs.Request;

public record CouponRequestDto(string CouponCode , decimal DiscountAmount)
{
    internal static Coupon ConvertToEntity(CouponRequestDto dto)
    {
        return new Coupon(dto.CouponCode, dto.DiscountAmount);
    }
}
