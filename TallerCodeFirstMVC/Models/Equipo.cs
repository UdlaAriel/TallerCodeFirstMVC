using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TallerCodeFirstMVC.Models
{
    public class Equipo
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string City { get; set; }
        [Range(0, 120)]
        public int Titles { get; set; }
        public bool ForeignAccept { get; set; }
        public Estadio? estadio { get; set; }

        [ForeignKey("Estadio")]
        public int IdEstadio { get; set; }

    }
}
