using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Api.src.Entities;

namespace Ecommerce.Api.src.DTOs;

public record CartHeaderDto
{
    public string Id { get; set; }
    public string UserId { get; set; }
    public string CouponCode { get; set; }

    internal static CartHeaderDto ConvertToDto(CartHeader header)
    {
        return new CartHeaderDto()
        {
            Id = header.Id,
            UserId = header.UserId,
            CouponCode = header.CouponCode,
        };
    }

    internal static CartHeader ConvertToEntity(CartHeaderDto cartHeaderdto)
    {
        return new CartHeader(cartHeaderdto.UserId, cartHeaderdto.CouponCode);
    }
}
