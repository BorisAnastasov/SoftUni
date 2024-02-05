using Forum.Data;
using Forum.Data.Models;
using Forum.Services.Interfaces;
using Forum.ViewModels.Post;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Forum.App.Controllers
{
    public class PostController : Controller
	{
		private readonly IPostService _postService;


        public PostController(IPostService postService)
        {
            _postService = postService;
        }


        public async Task<IActionResult> All() 
		{
			var posts = await this._postService.ListAllAsync();

			return View(posts);
		}

		public async Task<IActionResult> Add() => View();

		[HttpPost]
		public async Task<IActionResult> Add(PostFormModel model) 
		{
			if (!ModelState.IsValid) 
			{ 
					return View(model);
			}

			try
			{
                await this._postService.AddPostAsync(model);
            }
            catch (Exception)
			{
				ModelState.AddModelError(string.Empty, "Unexpected error with your posting!");
				return View(model);
			}


			return RedirectToAction("All","Post");
		}

		public async Task<IActionResult> Edit(string id) 
		{
			try
			{
				PostFormModel model =  await _postService.GetForEditByIdAsync(id);

				return View(model);
			}
			catch (Exception)
			{
				return this.RedirectToAction("All","Post");
			}
		}

		[HttpPost]
		public async Task<IActionResult> Edit(string id, PostFormModel model) 
		{
			if (!ModelState.IsValid) 
			{ 
				return this.View(model);
			}

			try
			{
				await this._postService.EditByIdAsync(id, model);
			}
			catch (Exception)
			{
				ModelState.AddModelError(string.Empty, "Unexpected error with your posting!");

				return View(model);
			}

			return RedirectToAction("All", "Post");

		}


		[HttpPost]
		public async Task<IActionResult> Delete(string id) 
		{
			await this._postService.DeleteById(id);
			
			return RedirectToAction("All", "Post");
        }


    }
}
