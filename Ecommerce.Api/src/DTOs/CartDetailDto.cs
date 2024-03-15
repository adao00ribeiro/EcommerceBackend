using Ecommerce.Api.src.Entities;

namespace Ecommerce.Api.src.DTOs;

public record CartDetailDto
{
    public long Id { get; set; }
    public long CartHeaderId { get; set; }
    public CartHeaderDto CartHeader { get; set; }
    public long ProductId { get; set; }
    public ProductDto Product { get; set; }
    public int Count { get; set; }


    internal static CartDetailDto ConvertToDto(CartDetail detail)
    {
        return new CartDetailDto()
        {
            Id = detail.Id,
            CartHeaderId = detail.CartHeaderId,
            CartHeader = CartHeaderDto.ConvertToDto(detail.CartHeader),
            ProductId = detail.ProductId,
            Product = ProductDto.ConvertToDto(detail.Product),
            Count = detail.Count

        };
    }

    internal static CartDetail ConvertToEntity(CartDetailDto dto)
    {
        return new CartDetail(
            dto.CartHeaderId,
            CartHeaderDto.ConvertToEntity(dto.CartHeader),
            dto.ProductId,
            ProductDto.ConvertToEntity(dto.Product),
            dto.Count
        );
    }
}
