using Forum.Data;
using Forum.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Forum.App.Controllers
{
	public class PostController : Controller
	{
		private readonly ForumDbContext _data;

		public PostController(ForumDbContext data) 
		{ 
			_data = data;
		}


		public async Task<IActionResult> All() 
		{
			var posts = await _data.Posts.Select(p => new PostViewModel()
			{
				Id = p.Id.ToString(),
				Title = p.Title,
				Content = p.Content
			}).ToListAsync();

			return View(posts);
		}
	}
}
