using Ecommerce.Api.src.Entities.Shared;

namespace Ecommerce.Api.src.Entities;


public class CartDetail : Entity
{
    public int Count { get; private set; }
    //--------------------------------
    public string CartHeaderId { get; private set; }
    public CartHeader CartHeader { get; private set; }
    public string ProductId { get; private set; }
    public Product Product { get; private set; }

    public CartDetail(int count, string cartHeaderId, string productId)
    {
        Count = count;
        CartHeaderId = cartHeaderId;
        ProductId = productId;
    }
}
