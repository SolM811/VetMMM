using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VetMMM.Models
{
    [Table("Mascotas")]
    public class Mascota
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string nombreM { get; set; }
        public string especieM { get; set; }
        public string fotoM { get; set; }
        public string razaM { get; set; }
        public int edadM { get; set; }
        public virtual Duenio duenio { get; set; }
    }
}
