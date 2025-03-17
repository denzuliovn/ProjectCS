using BusinessObject;

namespace Repositories
{
    public interface ICategoryRepository
    {
        List<Category> GetCategories();
    }
}