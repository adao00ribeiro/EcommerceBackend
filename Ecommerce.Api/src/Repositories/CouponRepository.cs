using Ecommerce.Api.src.Context;
using Ecommerce.Api.src.Entities;
using Ecommerce.Api.src.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Api.src.Repositories;

public class CouponRepository(DataContext context) : ICouponRepository
{

    private readonly DataContext dataContext = context;

    public async Task<Coupon> GetCouponByCouponCode(string couponCode)
    {
        var coupon = await dataContext.Coupons.FirstOrDefaultAsync(c => c.CouponCode == couponCode);
        if (coupon is null)
        {
            throw new Exception("NAO ENCONTRADO");
        }
        return coupon;
    }
}
