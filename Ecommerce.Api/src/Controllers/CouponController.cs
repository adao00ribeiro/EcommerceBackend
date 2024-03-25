using Ecommerce.Api.src.Controllers.Shared;
using Ecommerce.Api.src.DTOs.Request;
using Ecommerce.Api.src.DTOs.Response;
using Ecommerce.Api.src.Interfaces.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Api.src.Controllers;

[ApiVersion("1.0")]
public class CouponController(ICouponRepository couponRepository) : ApiControllerBase
{
    private readonly ICouponRepository CouponRepository = couponRepository;

    [HttpGet("{couponCode}")]
    public async Task<ActionResult<CouponResponseDto>> GetCouponByCouponCode(string couponCode)
    {
        var coupon = await CouponRepository.GetCouponByCouponCode(couponCode);
        if (coupon == null)
        {
            throw new Exception("O registro não existe na base de dados.");
        }
        return Ok(CouponResponseDto.ConvertToDto(coupon));
    }
    [HttpPost()]
    public async Task<ActionResult<string>> Create(CouponRequestDto dto)
    {
        throw new Exception("O registro não existe na base de dados.");
    }


}
