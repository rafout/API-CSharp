using API.Domain.Models;

namespace API.Domain.Interfaces.Repositories
{
    public interface IProductRepository
    {
        Task Create(ProductModel user);
        Task<List<ProductModel>> GetAll();
        Task<ProductModel> GetById(int id);
        Task<List<ProductModel>> GetProductsWithFilters(string name, string description, string value);
        Task Update(ProductModel user);
        Task Delete(int id);
    }
}
