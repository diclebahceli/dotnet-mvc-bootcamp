namespace FormApp.Models
{
    public class Repository
    {
        private static readonly List<Product> _product = new();
        private static readonly List<Category> _category = new();

        static Repository()
        {
            _category.Add(new Category { CategoryId = 1, Name = "Roman" });
            _category.Add(new Category { CategoryId = 2, Name = "Kisisel Gelisim" });

            _product.Add(new Product { ProductId = 1, BookName = "Son Ayi", PageCount = 224, IsActive = true, Image = "1.jpg", CategoryId = 1 });
            _product.Add(new Product { ProductId = 2, BookName = "Tarik Bugra", PageCount = 165, IsActive = true, Image = "2.jpg", CategoryId = 2 });
            _product.Add(new Product { ProductId = 3, BookName = "Cadi", PageCount = 550, IsActive = false, Image = "3.jpg", CategoryId = 1 });

        }

        public static List<Product> Products { get { return _product; } }
        public static void CreateProduct(Product entity)
        {
            _product.Add(entity);
        }
        public static List<Category> Categories { get { return _category; } }


        public static void EditProduct(Product updateProduct)
        {
            var entity = _product.FirstOrDefault(b => b.ProductId == updateProduct.ProductId);
            if (entity != null)
            {
                entity.BookName = updateProduct.BookName;
                entity.PageCount = updateProduct.PageCount;
                entity.Image = updateProduct.Image;
                entity.CategoryId = updateProduct.CategoryId;
            }
        }

        public static void DeleteProduct(Product entities)
        {
            var entity = _product.FirstOrDefault(b => b.ProductId == entities.ProductId);
            if (entity != null)
            {
                _product.Remove(entity);
            }
        }


    }
}