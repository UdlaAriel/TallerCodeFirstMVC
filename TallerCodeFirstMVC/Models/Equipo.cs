namespace TallerCodeFirstMVC.Models
{
    public class Equipo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Titles { get; set; }
        public bool ForeignAccept { get; set; }
        public Estadio? estadio { get; set; } = null;
        public int IdEstadio { get; set; }

    }
}
