using Study.Time.Management.Domain.Entities;
using System.Threading.Tasks;

namespace Study.Time.Management.Domain.Contractrs
{
    public interface ICategoryRepository
    {
        Task<int> Create(Category category);
        Task<Category> Get(int id);
        Task Update(Category category);
    }
}
