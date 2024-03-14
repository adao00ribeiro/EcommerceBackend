using System.ComponentModel.DataAnnotations.Schema;
using Ecommerce.Api.src.Entities.Shared;

namespace Ecommerce.Api.src.Entities;
public class CartHeader : Entity
{
    public string UserId { get; set; }
    public string CouponCode { get; set; }
}
