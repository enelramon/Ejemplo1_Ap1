namespace Ejemplo1_Ap1.Models;

using System.ComponentModel.DataAnnotations;

public class Tickets
{
    [Key]
    public int TicketId { get; set; }
    [Required(ErrorMessage = "El campo {0} es requerido")]
    public string Cliente { get; set; }
    [Required(ErrorMessage = "El campo {0} es requerido")]
    public string SolicitadoPor { get; set; }
    public string Asunto { get; set; }
    public string Solicitud { get; set; }
}