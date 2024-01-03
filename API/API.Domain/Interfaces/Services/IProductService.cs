using API.Domain.Models;
using API.Domain.Validations.Base;

namespace API.Domain.Interfaces.Services
{
    internal interface IProductService
    {
        Task<Response> Create(ProductModel user);
        Task<Response<List<ProductModel>>> GetAll();
        Task<Response<ProductModel>> GetById(int id);
        Task<Response<List<ProductModel>>> GetProductsWithFilters(string name, string description, string value);
        Task<Response> Update(ProductModel user);
        Task<Response> Delete(int id);
    }
}
