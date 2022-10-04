using System.ComponentModel.DataAnnotations;

namespace ArticulosAPI.Model
{
    public class Articulos
    {
        [Key]
        public int AriticuloId { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public double Precio { get; set; }
        public double Existencia { get; set; }

    }
}
