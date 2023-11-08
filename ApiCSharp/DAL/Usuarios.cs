using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;

namespace DAL
{
    public class Usuarios
    {
        

        [Key]//Indicar que es una primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//Para idicar que es incrementable
        public int id_usuario { get; set; }
        
        public string dni_usuario { get; set; }
        public string? nombre_usuario { get; set; }
        public string? apellidos_usuario { get; set; }
        public string? tlf_usuario { get; set; }

        public string? email_usuario { get; set; }
        public string clave_usuario { get; set; }
        
        public int id_acceso { get; set; }
        [ForeignKey("id_acceso")]
        public virtual Accesos Accesos { get; set; }
        public bool? estaBloqueado_usuario { get; set; }
        [Column(TypeName = "timestamp without time zone")]
        public DateTime? fch_fin_bloqueo_usuario { get; set; }
        [Column(TypeName = "timestamp without time zone")]
        public DateTime? fch_alta_usuario { get; set; }
        [Column(TypeName = "timestamp without time zone")]
        public DateTime? fch_baja_usuario { get; set; }

        public Usuarios(string dni_usuario,string clave_usuario, int id_acceso)
        {
            
            this.dni_usuario = dni_usuario;
            this.clave_usuario = clave_usuario;
            this.id_acceso = id_acceso;
        }
        public Usuarios(int id_usuario, string dni_usuario, string clave_usuario, int id_acceso)
        {
            this.id_usuario = id_usuario;
            this.dni_usuario = dni_usuario;
            this.clave_usuario = clave_usuario;
            this.id_acceso = id_acceso;
        }
    }
    
    
}
