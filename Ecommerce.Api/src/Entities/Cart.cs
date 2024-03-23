using Ecommerce.Api.src.DTOs;

namespace Ecommerce.Api.src.Entities;

public class Cart
{
    public CartHeader CartHeader { get; private set; }
    public IEnumerable<CartDetail> CartDetails { get; private set; }

    public Cart(CartHeader cartHeader, IEnumerable<CartDetail> cartDetails)
    {
        CartHeader = cartHeader;
        CartDetails = cartDetails;
    }

    
}
