using Forum.ViewModels.Post;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Services.Interfaces
{
    public interface IPostService
    {
        Task<IEnumerable<PostViewModel>> ListAllAsync();

        Task AddPostAsync(PostFormModel model);

        Task<PostFormModel> GetForEditByIdAsync(string id);

        Task EditByIdAsync(string id, PostFormModel model);

        Task DeleteById(string id);
    }
}
