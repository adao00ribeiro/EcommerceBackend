using Ecommerce.Api.src.Entities.Shared;

namespace Ecommerce.Api.src.Entities;
public class CartHeader : Entity
{

    public string UserId { get; private set; }
    public string CouponCode { get; private set; }

    public CartHeader(string userId, string couponCode)
    {
        UserId = userId;
        CouponCode = couponCode;
    }

}
