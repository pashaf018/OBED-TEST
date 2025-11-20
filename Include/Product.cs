using Microsoft.Data.Sqlite;

namespace OBED.Include
{
    public enum ProductType
    {
        MainDish,
        SideDish,
        Drink,
        Appetizer
    }

    class Product(int placeid, string name, ProductType type, (float value, bool perGram) price)
    {
        public int Place_id { get; private set; } = placeid;
        public string Name { get; init; } = name;
        public (float value, bool perGram) Price { get; private set; } = price;
        public ProductType Type { get; init; } = type;

        // TODO: SetPrice с процеркой на тип учётки

        //public static Product? Load()
        //{
        //    string dbConnectionString = "Data Source=OBED_DB.db";
        //    using(SqliteConnection connection = new SqliteConnection(dbConnectionString))
        //    {
        //        connection.Open();
        //        SqliteCommand command = new SqliteCommand();
        //        command.Connection = connection;
        //    }
        //}

        //public static bool Save(Product product)
        //{
        //    string dbConnectionString = "Data Source=OBED_DB.db";
        //    using (SqliteConnection connection = new SqliteConnection(dbConnectionString))
        //    {
        //        connection.Open();
        //        SqliteCommand command = new SqliteCommand();
        //        command.Connection = connection;
        //        command.CommandText = $@"CREATE TABLE IF NOT EXISTS "
        //    }
        //}
    }
}
