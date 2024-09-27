namespace Tarea1IngWeb.Models
{
    public class ProductRepository
    {
        private static List<Product> _products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Price = 1200, Quantity = 10 },
            new Product { Id = 2, Name = "Phone", Price = 800, Quantity = 15 }
        };

        public static List<Product> GetAllProducts()
        {
            return _products;
        }

        public static Product GetProductById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }

        public static void AddProduct(Product product)
        {
            product.Id = _products.Max(p => p.Id) + 1;  // Genera un nuevo ID
            _products.Add(product);
        }

        public static void UpdateProduct(Product product)
        {
            var existingProduct = _products.FirstOrDefault(p => p.Id == product.Id);
            if (existingProduct != null)
            {
                existingProduct.Name = product.Name;
                existingProduct.Price = product.Price;
                existingProduct.Quantity = product.Quantity;
            }
        }

        public static void DeleteProduct(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                _products.Remove(product);
            }
        } 
    }
}
