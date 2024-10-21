using System.ComponentModel.DataAnnotations;

namespace TallerCodeFirstMVC.Models
{
    public class Estadio
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Direction { get; set; }
        [MaxLength (100)]
        public string City { get; set; }
        public int Capacity { get; set; }
    }
}
