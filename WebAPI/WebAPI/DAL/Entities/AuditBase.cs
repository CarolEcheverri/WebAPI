using System.ComponentModel.DataAnnotations;

namespace WebAPI.DAL.Entities
{
    public class AuditBase
    {
        [Key] //DataAnnotation me sirve para definir que esta propiedad ID es una PK
        [Required] //No permite nulos 
        public Guid Id { get; set; } //Sera la PK para todas las tablas de mi BD
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set;}
    }
}
