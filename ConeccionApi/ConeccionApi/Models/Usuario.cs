using System.ComponentModel.DataAnnotations.Schema;

namespace ConeccionApi.Models
{
    public class Usuario
    {
        public int id_usuario { get; set; }

        public string dni_usuario { get; set; }
        public string? nombre_usuario { get; set; }
        public string? apellidos_usuario { get; set; }
        public string? tlf_usuario { get; set; }

        public string? email_usuario { get; set; }
        public string clave_usuario { get; set; }

        public int id_acceso { get; set; }
      
        public bool? estaBloqueado_usuario { get; set; }
        
        public DateTime? fch_fin_bloqueo_usuario { get; set; }
       
        public DateTime? fch_alta_usuario { get; set; }
        
        public DateTime? fch_baja_usuario { get; set; }

        public override string ToString()
        {
           string  nombreCompleto = String.Format(nombre_usuario + " " + apellidos_usuario);
            return String.Format("La id es:{0} el dni es:{1} el nombre es es:{2}",id_usuario,dni_usuario,nombreCompleto);
        }
    }
}
