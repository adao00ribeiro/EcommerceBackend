namespace Ecommerce.Api.src.DTOs;

public record CartDto
{
    public CartHeaderDto CartHeader { get; set; }
    public IEnumerable<CartDetailDto> CartDetails { get; set; }
}
