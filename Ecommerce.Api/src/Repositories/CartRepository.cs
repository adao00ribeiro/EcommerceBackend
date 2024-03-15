using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Api.src.Context;
using Ecommerce.Api.src.DTOs;
using Ecommerce.Api.src.Entities;
using Ecommerce.Api.src.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Api.src.Repositories;

public class CartRepository(DataContext _dataContext) : ICartRepository
{
    private readonly DataContext dataContext = _dataContext;

    public Task<CartDto> FindCartByUserId(string userId)
    {
        return FindCartByUserId(userId, dataContext);
    }

    public async Task<CartDto> FindCartByUserId(string userId, DataContext dataContext)
    {
        CartHeader? header = await dataContext.CartHeaders.FirstOrDefaultAsync(c => c.UserId == userId);
        var details = dataContext.CartDetails.Where(c => c.CartHeaderId == header.Id).Include(c => c.Product);
        Cart cart = new(header, details);
        return CartDto.ConvertToDto(cart);
    }
    public async Task<bool> ApplyCoupon(string userId, string couponCode)
    {
        var header = await dataContext.CartHeaders.Where(c => c.UserId == userId).FirstOrDefaultAsync();
        if (header is null)
        {
            return false;
        }
        dataContext.CartHeaders.Update(new CartHeader(header.UserId, couponCode));
        await dataContext.SaveChangesAsync();
        return true;
    }
    public async Task<CartDto> SaveOrUpdateCart(CartDto cartdto)
    {


        //Check if CartHeader is null
        var cartHeader = await dataContext.CartHeaders.AsNoTracking().FirstOrDefaultAsync(
            c => c.UserId == cartdto.CartHeader.UserId);
        Cart cart = null;
        if (cartHeader == null)
        {
            cart = await SaveCart(cartdto);
        }
        else
        {
            cart = await UpdateCart(cartdto);
        }
        return CartDto.ConvertToDto(cart);
    }
    private async Task<Cart> SaveCart(CartDto dto)
    {
        Cart cart = CartDto.ConvertToEntity(dto);
        dataContext.CartHeaders.Add(cart.CartHeader);
        await dataContext.SaveChangesAsync();
        return cart;
    }

    private async Task<Cart> UpdateCart(CartDto dto)
    {
        Cart cart = CartDto.ConvertToEntity(dto);
        //If CartHeader is not null
        //Check if CartDetails has same product
        var cartDetail = await dataContext.CartDetails.AsNoTracking().FirstOrDefaultAsync(
            p => p.ProductId == dto.CartDetails.FirstOrDefault().ProductId &&
            p.CartHeaderId == dto.CartHeader.Id);

        return cart;
    }
    public async Task<bool> RemoveCoupon(string userId)
    {
        throw new NotImplementedException();
    }
    public async Task<bool> RemoveFromCart(string cartDetailsId)
    {
        try
        {
            CartDetail cartDetail = await dataContext.CartDetails
                .FirstOrDefaultAsync(c => c.Id == cartDetailsId);

            int total = dataContext.CartDetails
                .Where(c => c.CartHeaderId == cartDetail.CartHeaderId).Count();

            dataContext.CartDetails.Remove(cartDetail);

            if (total == 1)
            {
                var cartHeaderToRemove = await dataContext.CartHeaders
                    .FirstOrDefaultAsync(c => c.Id == cartDetail.CartHeaderId);
                dataContext.CartHeaders.Remove(cartHeaderToRemove);
            }
            await dataContext.SaveChangesAsync();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
    public async Task<bool> ClearCart(string userId)
    {
        throw new NotImplementedException();
    }
}
