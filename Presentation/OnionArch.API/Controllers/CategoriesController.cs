using Microsoft.AspNetCore.Mvc;
using OnionArch.Application.Interfaces;

namespace OnionArch.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public IActionResult Getcategories()
        {

            var categories = _categoryService.GetCategories();
            return Ok(categories);

        }


    }
}
