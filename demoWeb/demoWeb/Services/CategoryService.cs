using demoWeb.Data;
using demoWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace demoWeb.Services;

public class CategoryService : ICategoryService
{
    private readonly AppDbContext _context;

    public CategoryService(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<List<Category>> GetAllCategoryAsync()
    {
        return await _context.Categories.ToListAsync();
    }

    public async Task<Category?> GetCategoryByIdAsync(int Id)
    {
        throw new NotImplementedException();
    }

    public async Task<Category> CreateCategoryAsync(Category category)
    {
        throw new NotImplementedException();
    }

    public async Task UpdateCategoryAsync(Category category)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteCategoryAsync(int Id)
    {
        throw new NotImplementedException();
    }
}