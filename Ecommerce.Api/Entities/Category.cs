using Ecommerce.Api.Entities.Shared;

namespace Ecommerce.Api.Entities;

public class Category : Entity
{
    public string Name { get; private set; }
    public string Slug { get; private set; }

}
