using BabyClothesShop.Models;

namespace BabyClothesShop.Repositories
{
    public interface IUnitOfWork
    {
        IGenericRepository<Product> Products { get; }
        IGenericRepository<Category> Categories { get; }

        Task<int> CompleteAsync();
    }
}
