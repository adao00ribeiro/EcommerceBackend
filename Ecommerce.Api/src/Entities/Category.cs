using Ecommerce.Api.src.Entities.Shared;

namespace Ecommerce.Api.src.Entities;

public class Category : Entity
{
 
    public string Name { get; private set; }
    public string Slug { get; private set; }
   public Category(string name, string slug)
    {
        Name = name;
        Slug = slug;
    }

}
