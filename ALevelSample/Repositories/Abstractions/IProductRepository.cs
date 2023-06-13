using System.Collections.Generic;
using System.Threading.Tasks;
using ALevelSample.Data.Entities;

namespace ALevelSample.Repositories.Abstractions;

public interface IProductRepository
{
    Task<int> AddProductAsync(string name, double price);
    Task<ProductEntity?> GetProductAsync(int id);
    public List<ProductEntity> GetProductsFromDb();
}