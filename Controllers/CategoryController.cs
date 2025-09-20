using BabyClothesShop.Models;
using BabyClothesShop.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BabyClothesShop.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // ✅ Tüm kategoriler
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var categories = await _unitOfWork.Categories.GetAllAsync();
            return Ok(categories);
        }

        // ✅ ID’ye göre kategori
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var category = await _unitOfWork.Categories.GetByIdAsync(id);
            if (category == null)
                return NotFound();

            return Ok(category);
        }

        // ✅ Yeni kategori oluştur
        [HttpPost]
        public async Task<IActionResult> Create(Category category)
        {
            await _unitOfWork.Categories.AddAsync(category);
            await _unitOfWork.CompleteAsync();
            return CreatedAtAction(nameof(GetById), new { id = category.Id }, category);
        }

        // ✅ Kategori güncelle
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Category category)
        {
            var existing = await _unitOfWork.Categories.GetByIdAsync(id);
            if (existing == null)
                return NotFound();

            existing.Name = category.Name;
            existing.AgeGroup = category.AgeGroup;

            _unitOfWork.Categories.Update(existing);
            await _unitOfWork.CompleteAsync();

            return NoContent();
        }

        // ✅ Kategori sil
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var existing = await _unitOfWork.Categories.GetByIdAsync(id);
            if (existing == null)
                return NotFound();

            _unitOfWork.Categories.Remove(existing);
            await _unitOfWork.CompleteAsync();

            return NoContent();
        }
    }
}
