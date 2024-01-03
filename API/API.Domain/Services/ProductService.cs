using API.Domain.Interfaces.Services;
using API.Domain.Models;
using API.Domain.Validations.Base;

namespace API.Domain.Services
{
    internal class ProductService : IProductService
    {
        public Task<Response> Create(ProductModel user)
        {
            throw new NotImplementedException();
        }

        public Task<Response> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<ProductModel>>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Response<ProductModel>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<ProductModel>>> GetProductsWithFilters(string name, string description, string value)
        {
            throw new NotImplementedException();
        }

        public Task<Response> Update(ProductModel user)
        {
            throw new NotImplementedException();
        }
    }
}
