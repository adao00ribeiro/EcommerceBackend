using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Api.src.Entities;

namespace Ecommerce.Api.src.DTOs.Request;

public record CouponRequestDto
{
    public string CouponCode { get; set; }
    public decimal DiscountAmount { get; set; }

    internal static Coupon ConvertToEntity(CouponRequestDto dto)
    {
        return new Coupon(dto.CouponCode, dto.DiscountAmount);
    }
}
