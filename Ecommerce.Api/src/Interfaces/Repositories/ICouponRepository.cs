using Ecommerce.Api.src.Entities;

namespace Ecommerce.Api.src.Interfaces.Repositories;

public interface ICouponRepository
{
    Task<Coupon> GetCouponByCouponCode(string couponCode);
}
