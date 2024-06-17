using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Models;

internal class Articulos
{
    [Key]
    public int ArticuloId { get; set; }

    [Required(ErrorMessage = "Favor de digitar una descripción.")]
    public string Descripcion { get; set; }

    [Range(1, 200000, ErrorMessage = "Favor de digitar el costo del articulo.")]
    public decimal Costo { get; set; }

    [Range(1, 200000, ErrorMessage = "Favor de digitar la ganancia del articulo.")]
    public decimal Ganancia { get; set; }

    public decimal Precio { get; set; }
}
