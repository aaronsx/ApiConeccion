using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Prestamos
    {
        //Primeary Key
        [Key]//Indicar que es una primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//Para idicar que es incrementable
        public int id_prestamo { get; set; }



        //ForeignKey de la tabla Usuarios
        public int id_usuario { get; set; }
        [ForeignKey("id_usuario")]
        public virtual Usuarios Usuarios { get; set; }


        //Campos de tiempos
        [Column(TypeName = "timestamp without time zone")]
        public DateTime? fch_inicio_prestamo { get; set; }
        [Column(TypeName = "timestamp without time zone")]
        public DateTime? fch_fin_prestamo { get; set; }
        [Column(TypeName = "timestamp without time zone")]
        public DateTime? fch_entrega_prestamo { get; set; }

        //ForeignKey de la tabla Estado Prestamo
        public int id_estado_prestamo { get; set; }
        [ForeignKey("id_estado_prestamo")]
    public virtual Estados_Prestamos Estados_Prestamos { get; set; }

    }
}
