using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Ecommerce.Api.src.Entities.Shared;

namespace Ecommerce.Api.src.Entities;


public class CartDetail : Entity
{
    public long CartHeaderId { get; set; }
    public CartHeader CartHeader { get; set; }
    public long ProductId { get; set; }
    public Product Product { get; set; }
    public int Count { get; set; }
}
