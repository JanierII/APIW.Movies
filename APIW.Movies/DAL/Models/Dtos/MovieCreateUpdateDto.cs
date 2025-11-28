using System.ComponentModel.DataAnnotations;

namespace API.W.Movies.DAL.Models.Dtos
{
    public class MovieCreateUpdateDto
    {
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(100, ErrorMessage = "El nombre no puede exceder 100 caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "La duración es obligatoria")]
        public int Duration { get; set; }

        public string? Description { get; set; } // Puede ser nulo

        [Required(ErrorMessage = "La clasificación es obligatoria")]
        [StringLength(10, ErrorMessage = "La clasificación no puede exceder 10 caracteres")]
        public string? Clasification { get; set; }
    }
}