using Ecommerce.Api.src.Entities;

namespace Ecommerce.Api.src.DTOs;

public record CartDetailDto
{
    public string Id { get; set; }
    public string CartHeaderId { get; set; }
    public CartHeaderDto CartHeader { get; set; }
    public string ProductId { get; set; }
    public ProductResponseDto Product { get; set; }
    public int Count { get; set; }


    internal static CartDetailDto ConvertToDto(CartDetail detail)
    {
        return new CartDetailDto()
        {
            Id = detail.Id,
            CartHeaderId = detail.CartHeaderId,
            CartHeader = CartHeaderDto.ConvertToDto(detail.CartHeader),
            ProductId = detail.ProductId,
            Product = ProductResponseDto.ConvertToDto(detail.Product),
            Count = detail.Count

        };
    }

    internal static CartDetail ConvertToEntity(CartDetailDto dto)
    {
        return new CartDetail(
            dto.Count,
            dto.CartHeaderId,
            dto.ProductId
        );
    }
}
