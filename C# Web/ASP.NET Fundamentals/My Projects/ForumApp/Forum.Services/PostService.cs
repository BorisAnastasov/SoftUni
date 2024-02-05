using Forum.Data;
using Forum.Data.Models;
using Forum.Services.Interfaces;
using Forum.ViewModels.Post;
using Microsoft.EntityFrameworkCore;

namespace Forum.Services
{
    public class PostService : IPostService
    {
        private readonly ForumDbContext _data;

        public PostService(ForumDbContext data)
        {
            _data = data;
        }
        public async Task<IEnumerable<PostViewModel>> ListAllAsync()
        {
            IEnumerable<PostViewModel> allPosts = await _data.Posts.Select(x => new PostViewModel
            {
                Id = x.Id.ToString(),
                Title = x.Title,
                Content = x.Content
            }).ToArrayAsync();

            return allPosts;
        }

        public async Task AddPostAsync(PostFormModel model) 
        {
            Post newPost = new Post()
            {
                Title = model.Title,
                Content = model.Content
            };

            await this._data.Posts.AddAsync(newPost);
            await this._data.SaveChangesAsync();
        }

        public async Task<PostFormModel> GetForEditByIdAsync(string id)
        {
            Post post = await this._data.Posts.FirstAsync(x=>x.Id.ToString().ToLower()==id.ToLower());
            return new PostFormModel()
            {
                Title = post.Title,
                Content = post.Content
            };
        }

        public async Task EditByIdAsync(string id, PostFormModel model)
        {
            Post post = await _data.Posts.FirstAsync(x => x.Id.ToString().ToLower() == id.ToLower());

            post.Title = model.Title;
            post.Content = model.Content;

            await this._data.SaveChangesAsync();
        }

        public async Task DeleteById(string id)
        {
            var post = await this._data.Posts.FirstAsync(x => x.Id.ToString().ToLower() == id.ToLower());

            this._data.Posts.Remove(post);
            await this._data.SaveChangesAsync();
        }
    }
}
