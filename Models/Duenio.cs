using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VetMMM.Models
{
    [Table("Duenios")]
    public class Duenio
    {
       
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string nombreD { get; set; }
        public int telefonoD { get; set; }
        public string domicilioD { get; set; }
    }
}
