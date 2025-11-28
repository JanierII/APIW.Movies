using API.W.Movies.DAL.Models;

namespace API.W.Movies.Repository.IRepository
{
    public interface IMovieRepository
    {
        // Métodos de lectura
        Task<ICollection<Movie>> GetMoviesAsync(); // Retorna LISTA DE PELICULAS [cite: 34]
        Task<Movie> GetMovieAsync(int id);         // Retorna UNA PELICULA POR ID [cite: 35]

        // Métodos de verificación (útiles para validaciones)
        Task<bool> MovieExistsByIdAsync(int id);
        Task<bool> MovieExistsByNameAsync(string name);

        // Métodos de escritura (Devuelven bool )
        Task<bool> CreateMovieAsync(Movie movie);  // Crea una pelicula [cite: 36]
        Task<bool> UpdateMovieAsync(Movie movie);  // Actualiza una pelicula [cite: 37]
        Task<bool> DeleteMovieAsync(int id);       // Elimina una pelicula [cite: 38]
    }
}