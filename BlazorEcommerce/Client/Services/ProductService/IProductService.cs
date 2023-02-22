namespace BlazorEcommerce.Client.Services.ProductService
{
    public interface IProductService
    {
        public List<Product> Products { get; set; }
        public Task GetProducts();
        public Task<ServiceResponse<Product>> GetProductById(int productId);
     
    }
}
