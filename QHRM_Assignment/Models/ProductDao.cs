using Dapper;
using Microsoft.Data.SqlClient;


namespace OHRM_Sanket_Patil.Models
{
    public class ProductDao
    {

        private readonly IConfiguration _config;

        public ProductDao(IConfiguration config)
        {
            _config = config;
        }

        public  IEnumerable<Product> getAllProducts()
        {
              IEnumerable<Product> products = null;

            using(var connection = new SqlConnection(_config.GetConnectionString("DefaultConnection")))
            {
                products = connection.Query<Product>("Select * from Products");
            }
            
            return products;
        }

        public void addProduct(Product product)
        {
            using (var connection = new SqlConnection(_config.GetConnectionString("DefaultConnection")))
            {
                connection.Execute("insert into Products (product,description,created) values (@product,@description,@created)",product);
            }
        }

        public Product getSingleProduct(int id)
        {
            Product product;

            using (var connection = new SqlConnection(_config.GetConnectionString("DefaultConnection")))
            {
                product = connection.QueryFirst<Product>("Select * from Products where id = @id",new {id = id});
            }

            return product;
        }

        public void updateProduct(Product product)
        {
            using (var connection = new SqlConnection(_config.GetConnectionString("DefaultConnection")))
            {
                connection.Execute("update Products set  product = @product, description = @description , created = @created where id = @id",product);
            }
           
        }

        public void deleteProduct(int id)
        {
            using (var connection = new SqlConnection(_config.GetConnectionString("DefaultConnection")))
            {
                connection.Execute("delete from Products where id = @id", new {id = id});
            }

        }


    }
}
