using Ecommerce.Api.src.Entities;

namespace Ecommerce.Api.src.DTOs;

public record CartDto
{
    public CartHeaderDto CartHeader { get; set; }
    public IEnumerable<CartDetailDto> CartDetails { get; set; }

    internal static CartDto ConvertToDto(Cart cart)
    {
        return new CartDto()
        {

            CartHeader = CartHeaderDto.ConvertToDto(cart.CartHeader),
            CartDetails = cart.CartDetails.Select(cart => CartDetailDto.ConvertToDto(cart))
        };
    }
    internal static Cart ConvertToEntity(CartDto dto)
    {
        return new Cart
        (
            CartHeaderDto.ConvertToEntity(dto.CartHeader),
            dto.CartDetails.Select(cartdetaildto => CartDetailDto.ConvertToEntity(cartdetaildto))
        );
    }
}
