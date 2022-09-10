using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Model
{
    public class TipoContactos
    {

            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            [Key]
            public int Id_TipoContacto { get; set; }
            [MaxLength(128), MinLength(3), Required]
            public string? Calle { get; set; }
            [MaxLength(1024), MinLength(0)]
            public string ContactoNro { get; set; }
   
    }
}
