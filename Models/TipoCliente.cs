using System.ComponentModel.DataAnnotations;

namespace Adrian_P1_AP2.Models
{
    public class TipoCliente
    {
        public int TipoClienteId { get; set; }

        [Required(ErrorMessage = "La descripción es obligatoria")]
        public string Descripcion { get; set; }
    }
}