using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Model
{
    public class Direcciones
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id_Direccion { get; set; }
        [MaxLength(128), MinLength(3), Required]
        public string? Calle { get; set; }
        [MaxLength(1024), MinLength(0)]
        public string? Observaciones { get; set; }

        [ForeignKey("Personas")]
        
        public virtual int Id_Persona { get; set; }

        public virtual Personas Personas { get; set; }
    }
}
