using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Api.src.Entities;

namespace Ecommerce.Api.src.DTOs.Response;

public class CouponResponseDto
{
    internal static CouponResponseDto ConvertToDto(Coupon coupon)
    {
        return new CouponResponseDto();
    }
}
