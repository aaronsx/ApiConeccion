using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    //Primeary Key
    //Indicar que es una primary key
    [PrimaryKey(nameof(id_prestamo), nameof(id_libro))]
    public class Rel_Libros_Prestamos
    {
        public int id_prestamo { get; set; }
      
        public virtual Prestamos prestamo { get; set; }

        public int id_libro { get; set; }
       
        public virtual Libros libro { get; set; }
    }
}
