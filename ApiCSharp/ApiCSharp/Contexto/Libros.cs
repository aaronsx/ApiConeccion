using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Libros
    {
        //Primeary Key
        [Key]//Indicar que es una primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//Para idicar que es incrementable
        public int id_libro { get; set; }

        public string? isbn_libro { get; set; }
        public string? titulo_libro { get; set; }
        public string? edicion_libro { get; set; }
        public int? cantidad_libro { get; set; }
        //ForeignKey de la tabla Editoriales
        public int id_editorial { get; set; }
        [ForeignKey("id_editorial")]
        public virtual Editoriales Editoriales { get; set; }

        //ForeignKey de la tabla Generos
        public int id_genero { get; set; }
        [ForeignKey("id_genero")]
        public virtual Generos Generos { get; set; }

        //ForeignKey de la tabla Generos
        public int id_coleccion { get; set; }
        [ForeignKey("id_coleccion")]
    public virtual Colecciones Colecciones { get; set; }
    }
}
