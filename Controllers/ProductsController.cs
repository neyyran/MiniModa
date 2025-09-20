using BabyClothesShop.Data;            // AppDbContext
using BabyClothesShop.Models;          // Product
using BabyClothesShop.Repositories;    // IUnitOfWork
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BabyClothesShop.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly AppDbContext _context;

        public ProductsController(IUnitOfWork unitOfWork, AppDbContext context)
        {
            _unitOfWork = unitOfWork;
            _context = context;
        }

        // GET /api/products
        // ?categoryId=5   veya   ?categoryIds=5,6,7,8  (çoklu filtre desteği)
        [HttpGet]
        public async Task<IActionResult> GetAll(
            [FromQuery] int? categoryId,
            [FromQuery] string? categoryIds)
        {
            IQueryable<Product> query = _context.Products
                                                .Include(p => p.Category)
                                                .AsNoTracking();

            if (!string.IsNullOrWhiteSpace(categoryIds))
            {
                var ids = categoryIds
                    .Split(',', StringSplitOptions.RemoveEmptyEntries)
                    .Select(s => s.Trim())
                    .Select(s => int.TryParse(s, out var v) ? (int?)v : null)
                    .Where(v => v.HasValue)
                    .Select(v => v!.Value)
                    .ToList();

                if (ids.Count > 0)
                    query = query.Where(p => ids.Contains(p.CategoryId));
            }
            else if (categoryId.HasValue)
            {
                query = query.Where(p => p.CategoryId == categoryId.Value);
            }

            var list = await query.OrderBy(p => p.Id).ToListAsync();
            return Ok(list);
        }

        // GET /api/products/12
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var product = await _context.Products
                                        .Include(p => p.Category)
                                        .AsNoTracking()
                                        .FirstOrDefaultAsync(p => p.Id == id);
            if (product == null) return NotFound();
            return Ok(product);
        }

        // POST /api/products
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Product product)
        {
            if (product == null) return BadRequest();

            await _unitOfWork.Products.AddAsync(product);
            await _unitOfWork.CompleteAsync();

            return CreatedAtAction(nameof(GetById), new { id = product.Id }, product);
        }

        // PUT /api/products/12
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Product product)
        {
            if (product == null || id != product.Id) return BadRequest();

            var existing = await _unitOfWork.Products.GetByIdAsync(id);
            if (existing == null) return NotFound();

            existing.Name = product.Name;
            existing.Price = product.Price;
            existing.ImageUrl = product.ImageUrl;
            existing.CategoryId = product.CategoryId;

            _unitOfWork.Products.Update(existing);
            await _unitOfWork.CompleteAsync();

            return NoContent();
        }

        // DELETE /api/products/12
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var existing = await _unitOfWork.Products.GetByIdAsync(id);
            if (existing == null) return NotFound();

            _unitOfWork.Products.Remove(existing);
            await _unitOfWork.CompleteAsync();

            return NoContent();
        }
    }
}
