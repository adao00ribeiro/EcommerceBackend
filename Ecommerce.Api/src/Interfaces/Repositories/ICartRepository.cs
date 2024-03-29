using Ecommerce.Api.src.DTOs;
using Ecommerce.Api.src.DTOs.Request;
using Ecommerce.Api.src.DTOs.Response;

namespace Ecommerce.Api.src.Interfaces.Repositories;

public interface ICartRepository
{
    Task<CartDto> FindCartByUserId(string userId);
    Task<CartDto> SaveOrUpdateCart(CartDto cart);
    Task<bool> RemoveFromCart(string cartDetailsId);
    Task<bool> ApplyCoupon(string userId, string couponCode);
    Task<bool> RemoveCoupon(string userId);
    Task<bool> ClearCart(string userId);
}
