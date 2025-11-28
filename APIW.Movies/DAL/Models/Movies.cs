using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.W.Movies.DAL.Models
{
    [Table("Movies")] // Buena práctica para asegurar el nombre en BD
    public class Movie : AuditBase
    {
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [MaxLength(100, ErrorMessage = "El nombre no puede tener más de 100 caracteres")]
        [Display(Name = "Nombre de la película")]
        public string Name { get; set; }

        [Required(ErrorMessage = "La duración es obligatoria")]
        [Display(Name = "Duración (minutos)")]
        public int Duration { get; set; }

        [Display(Name = "Descripción")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "La clasificación es obligatoria")]
        [MaxLength(10, ErrorMessage = "La clasificación no puede tener más de 10 caracteres")]
        [Display(Name = "Clasificación")]
        public string Clasification { get; set; }
    }
}