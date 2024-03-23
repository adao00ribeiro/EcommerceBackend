using Ecommerce.Api.src.Controllers.Shared;
using Ecommerce.Api.src.DTOs;
using Ecommerce.Api.src.Interfaces.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Api.src.Controllers;


[ApiVersion("1.0")]
public class CartController(ICartRepository cartRepository) : ApiControllerBase
{
    private readonly ICartRepository _repository = cartRepository;

    [HttpGet("user/{userId}")]
    public async Task<ActionResult<CartDto>> FindByUserId(string userId)
    {
        var cart = await _repository.FindCartByUserId(userId);
        if (cart == null) return NotFound();
        return Ok(cart);
    }

    [HttpPost()]
    public async Task<ActionResult<CartDto>> AddCart(CartDto cart)
    {
        var cartTemp = await _repository.SaveOrUpdateCart(cart);
        if (cartTemp == null) return NotFound();
        return Ok(cartTemp);
    }

    [HttpPut()]
    public async Task<ActionResult<CartDto>> UpdateCart(CartDto cart)
    {
        var cartTemp = await _repository.SaveOrUpdateCart(cart);
        if (cartTemp == null) return NotFound();
        return Ok(cartTemp);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<CartDto>> RemoveCart(string id)
    {
        var status = await _repository.RemoveFromCart(id);
        if (!status) return BadRequest();
        return Ok(status);
    }
}
