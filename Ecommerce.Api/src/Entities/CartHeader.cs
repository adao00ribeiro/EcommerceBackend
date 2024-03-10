using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Api.src.Entities;
public class CartHeader
{
    public long Id { get; set; }

    public string UserId { get; set; }
    public string CouponCode { get; set; }
}
