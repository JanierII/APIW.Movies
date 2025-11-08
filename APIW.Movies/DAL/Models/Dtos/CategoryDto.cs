using System.ComponentModel.DataAnnotations;
using System.Data;

namespace APIW.Movies.DAL.Models.Dtos
{
    public class CategoryDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre de la categoria es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El numuero maximo de caracteres es de 100.")]

        public string Name { get; set; }
        public DateTime CreateDate { get; set; }

        public  DateTime ModifiedDate { get; set; }
    }
}
