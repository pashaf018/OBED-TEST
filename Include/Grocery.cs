namespace OBED.Include
{
    class Grocery(int placeid,string name, string? description, List<Review>? reviews = null, List<Product>? menu = null, List<string>? tegs = null) : BasePlace(placeid,name, description, reviews, menu, tegs)
    {
	}
}
