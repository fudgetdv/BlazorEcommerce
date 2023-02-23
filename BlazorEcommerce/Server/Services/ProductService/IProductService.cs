﻿namespace BlazorEcommerce.Server.Services.ProductService
{
    public interface IProductService
    {
        public Task<ServiceResponse<List<Product>>> GetProductsAsync();
        public Task<ServiceResponse<Product>> GetProductAsync(int productId);
        public Task<ServiceResponse<List<Product>>> GetProductByCategoryAsync(string categoryUrl);
    }
}
