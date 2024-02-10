using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;
using TaskBoardApp.Data;

namespace TaskBoardApp.Controllers
{
	public class BoardController : Controller
	{
		private readonly TaskBoardAppDbContext data;

        public BoardController(TaskBoardAppDbContext _data)
        {
            data = _data;
        }

		public async Task<IActionResult> All() 
		{ 
			
		}
	}
}
