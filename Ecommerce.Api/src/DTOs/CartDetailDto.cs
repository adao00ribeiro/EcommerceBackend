using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Api.src.DTOs.Response;

namespace Ecommerce.Api.src.DTOs;

public record CartDetailDto
{
    public long Id { get; set; }
    public long CartHeaderId { get; set; }
    public CartHeaderDto CartHeader { get; set; }
    public long ProductId { get; set; }
    public ProductDto Product { get; set; }
    public int Count { get; set; }
}
