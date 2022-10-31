namespace My_ASpNetCoreApp.Web.Models
{
    public class ProductRepository
    {
        private List<Product> _products;


        public List<Product> GetAll() => _products;

        public void Add (Product NewProduct) => _products.Add(NewProduct);

        public void Remove(int id)
        {
            var hasProduct = _products.FirstOrDefault(x=> x.Id == id);

            if (hasProduct == null)
            {
                throw new Exception($"BU Id({id}) Bulunmamaktadır.");

            }

            _products.Remove(hasProduct);

        }

        public void Update(Product updateProduct)
        {
            var hasProduct = _products.FirstOrDefault(x => x.Id == updateProduct.Id);

            if (hasProduct == null)
            {
                throw new Exception($"BU Id({updateProduct.Id}) Bulunmamaktadır.");

            }

            hasProduct.Name = updateProduct.Name;
            hasProduct.Price = updateProduct.Price;
            hasProduct.Stock = updateProduct.Stock;

            var index = _products.FindIndex(x => x.Id == updateProduct.Id);
            _products[index] = hasProduct;


        }
    }
}
