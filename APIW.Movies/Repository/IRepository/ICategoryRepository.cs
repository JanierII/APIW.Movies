using APIW.Movies.DAL.Models;

namespace APIW.Movies.Repository.IRepository
{
    public interface ICategoryRepository
    {
        Task<ICollection<Category>> GetCategoriesAsync(); // RETORNA UNA LISTA DE CATEGORIAS
        Task<Category?> GetCategoryByIdAsync(int id); // RETORNA UNA CATEGORIA POR ID

        Task<bool> CategoryExistsAsync(int id); // VERIFICA SI UNA CATEGORIA EXISTE POR ID

        Task<bool> CategotyExistsByNameAsync(string name); // VERIFICA SI UNA CATEGORIA EXISTE POR NOMBRE

        Task<bool> CreateCategoryAsync(Category category); // CREA UNA NUEVA CATEGORIA

        Task<bool> UpdateCategoryAsync(Category category); // ACTUALIZA NOMBRE Y FECHA DE ACTUALIZACION UNA NUEVA CATEGORIA

        Task<bool> DeleCateCategoryAsync(int id); // ELIMINA UNA CATEGORIA
        Task<bool> CategoryExistsByNameAsync(string name);
        Task GetCategoryAsync(int id);
    }
}
