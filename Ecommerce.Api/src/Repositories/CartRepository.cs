using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Api.src.DTOs;
using Ecommerce.Api.src.Interfaces.Repositories;

namespace Ecommerce.Api.src.Repositories;

public class CartRepository : ICartRepository
{
    public Task<bool> ApplyCoupon(string userId, string couponCode)
    {
        throw new NotImplementedException();
    }

    public Task<bool> ClearCart(string userId)
    {
        throw new NotImplementedException();
    }

    public Task<CartDto> CreateCart(CartDto cart)
    {
        throw new NotImplementedException();
    }

    public Task<CartDto> FindCartByUserId(string userId)
    {
        throw new NotImplementedException();
    }

    public Task<bool> RemoveCoupon(string userId)
    {
        throw new NotImplementedException();
    }

    public Task<bool> RemoveFromCart(long cartDetailsId)
    {
        throw new NotImplementedException();
    }

    public Task<CartDto> UpdateCart(CartDto cart)
    {
        throw new NotImplementedException();
    }
}
