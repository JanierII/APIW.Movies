using APIW.Movies.DAL;
using APIW.Movies.DAL.Models;
using APIW.Movies.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace APIW.Movies.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private  readonly ApplicationDBContext _context;

        public CategoryRepository(ApplicationDBContext contex)
        {
            _context = contex;
        }

        public async Task<bool> CategoryExistsByIdAsync(int id)
        {
            return await _context.Categories
                .AsNoTracking()
                .AnyAsync(C => C.Id == id); // LAMBDA EXPRESSION

        }

        public async Task<bool> CategotyExistsByNameAsync(string name)
        {
            return await _context.Categories
                .AsNoTracking()
                .AnyAsync(C => C.Name == name); // LAMBDA EXPRESSION
        }

        public async Task<bool> CreateCategoryAsync(Category category)
        {
            category.CreateDate = DateTime.UtcNow;
            await _context.Categories.AddAsync(category);
            return await SaveAsync(); //SQL INSERT
        }

        public async Task<bool> DeleCateCategoryAsync(int id)
        {
            var categorie  = await GetCategoryByIdAsync(id); // primero consultamos si existe la categoria

            if (categorie == null)
            {

                return false; //la categoiria no existe
            }
            _context.Categories.Remove(categorie); // eliminamos la categoria
            return await SaveAsync(); // SQL DELETE
        }

        public async Task<ICollection<Category>> GetCategoriesAsync()
        {
            return await _context.Categories
                .AsNoTracking()
                .OrderBy(C => C.Name) // LAMBDA EXPRESSION
                .ToListAsync();
        }

        public async Task<Category?> GetCategoryByIdAsync(int id)
        {
            return await _context.Categories
                .AsNoTracking()
                .FirstOrDefaultAsync(C => C.Id == id ); //LAMBDA EXPRESSION

        }

        public async Task<bool> UpdateCategoryAsync(Category category)
        {
            category.ModifiedDate = DateTime.UtcNow;
            _context.Categories.Update(category);
            return await SaveAsync();
        }

        private async Task<bool> SaveAsync()
        {
            return await _context.SaveChangesAsync() >= 0 ? true : false;
        }
    }
}
