using System.Net.Http;

namespace ConeccionApi.Models
{
    
    public class Acceso
    {
        public int id_acceso { get; set; }
        public string? codigo_acceso { get; set; }
        public string? descripcion_acceso { get; set; }

        public override string ToString()
        {
            return String.Format("La id es:{0} el codigo es:{1} la descripcion es:{2}", id_acceso, codigo_acceso, descripcion_acceso);
        }
    }
}
