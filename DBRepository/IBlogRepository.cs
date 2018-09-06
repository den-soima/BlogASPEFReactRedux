using System.Threading.Tasks;
using Models;

namespace DBRepository
{
    public interface IBlogRepository
    {
        Task<Page<Post>> GetPosts(int index, int pageSize, string tag);
        
    }
}