using APIW.Movies.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace APIW.Movies.DAL
{
    public class ApplicationDBContext :DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        { 

        }

        //Seccion para crear el DBSet de las entidades o modelos
        public DbSet<Category> Categories { get; set; }
    }
}
