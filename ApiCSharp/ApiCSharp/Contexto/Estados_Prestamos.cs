using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Estados_Prestamos
    {
        //Primeary Key
        [Key]//Indicar que es una primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//Para idicar que es incrementable
        public int id_estado_prestamo { get; set; }

        public string codigo_estado_prestamo { get; set; }
        public string descripcion_estado_prestamo { get; set; }

    }
}
