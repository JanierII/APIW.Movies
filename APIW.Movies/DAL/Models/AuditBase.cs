using System.ComponentModel.DataAnnotations;
using System.Data;

namespace APIW.Movies.DAL.Models
{
    public class AuditBase
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
