namespace OBED.Include
{
    abstract class BasePlace(string name, List<Reviev>? placeRevievs = null, List<Product>? menu = null)
    {
        public string Name { get; private set; } = name;
        public List<Reviev> PlaceRevievs { get; private set; } = placeRevievs ?? [];
        public List<Product> Menu { get; private set; } = menu ?? [];

        public virtual bool AddRevievs(Reviev reviev)
        {
            if (!PlaceRevievs.Where(x => x.FromID == reviev.FromID).Any())
            {
                PlaceRevievs.Add(reviev);
                return true;
            }
            return false;
        }
        public virtual bool DeleteRevievs(long fromID)
        {
            var removeCheck = PlaceRevievs.Where(x => x.FromID == fromID);
            if (removeCheck.Any())
            {
                PlaceRevievs.Remove(removeCheck.First());
                return true;
            }
            return false;
        }
    }

    class Canteen(string name, int frame, int floor, List<Reviev>? placeRevievs = null, List<Product>? menu = null) : BasePlace(name, placeRevievs, menu)
    {
        public int Frame { get; private set; } = frame;
        public int Floor { get; private set; } = floor;
    }

    enum ProductType
    {
        MainDishes,
        SideDishes,
        Drinks,
        Appetizer
    }

    class Product(string pName, double price, bool isPer100G, ProductType type)
    {
        public string PName { get; private set; } = pName;
        public double Price { get; private set; } = price;
        public bool IsPer100G { get; private set; } = isPer100G;
        public ProductType Type { get; private set; } = type;
    }
}
