using System.ComponentModel.DataAnnotations;

namespace APIW.Movies.DAL.Models
{
    public class Category : AuditBase
    {
        [Required] //Este dato indica que el campo es obligatorio
        [Display (Name = "Nomnre de la categoria")] //Me sirve para personalizar el nombre que se muestra en las vistas o mensajes de error
        public string Name { get; set; }
    }
}

/* estos son los que va a tener la tabla Category
 *Id
 *Name
 *CreateDate
 *ModifiedDate
 */