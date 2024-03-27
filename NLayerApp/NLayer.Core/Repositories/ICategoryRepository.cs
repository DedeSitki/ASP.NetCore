using NLayer.Core.Models;

namespace NLayer.Core.Repositories
{
    //CategoriesController eklendikten sonra oluşturuldu API
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        Task<Category> GetSingleCategoryByIdWithProductsAsync(int categoryId);
    }
}
