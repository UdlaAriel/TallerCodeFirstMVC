using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TallerCodeFirstMVC.Models
{
    public class Jugador
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public Equipo? Equipo { get; set; } = null;

        [ForeignKey(nameof(Equipo))]
        public int idEquipo {  get; set; }
    }
}
