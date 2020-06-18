using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RemaApp2020.Data;
using RemaApp2020.Models;

namespace RemaApp2020.Controllers
{
    public class CategoriesController : ControllerBase
    {
        private ProductContext ProductContext;
        private Category Category;

        public CategoriesController(ProductContext, ProductContext)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Product.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var category = (id);

            if (category == null)
            {
                return NotFound();
            }

            return category;
        }
    }
}
