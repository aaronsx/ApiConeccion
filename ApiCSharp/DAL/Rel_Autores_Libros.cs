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
    [PrimaryKey(nameof(id_autor), nameof(id_libro))]
    public class Rel_Autores_Libros
    { 
        public int id_autor { get; set; }
        public virtual Autores Autores { get; set; }
        public int id_libro { get; set; }
       
        public virtual Libros Libros { get; set; }

    }
}
