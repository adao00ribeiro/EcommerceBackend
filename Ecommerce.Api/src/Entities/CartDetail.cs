using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Ecommerce.Api.src.DTOs;
using Ecommerce.Api.src.Entities.Shared;

namespace Ecommerce.Api.src.Entities;


public class CartDetail : Entity
{
    public long CartHeaderId { get; private set; }
    public CartHeader CartHeader { get; private set; }
    public long ProductId { get; private set; }
    public Product Product { get; private set; }
    public int Count { get; private set; }
    public CartDetail(long cartHeaderId, CartHeader cartHeader, long productId, Product product, int count)
    {
        CartHeaderId = cartHeaderId;
        CartHeader = cartHeader;
        ProductId = productId;
        Product = product;
        Count = count;
    }

}
