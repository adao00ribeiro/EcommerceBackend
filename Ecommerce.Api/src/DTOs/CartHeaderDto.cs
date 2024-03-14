using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Api.src.DTOs;

public record CartHeaderDto
{
    public long Id { get; set; }
    public string UserId { get; set; }
    public string CouponCode { get; set; }
}
