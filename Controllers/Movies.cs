using eTickets.Date.@enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Controllers
{
    public class Movies
    {
        [Key]
        public int Id { get; set; }
        public string Desrciption { get; set; }
        public string Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }

        //Relationship
        public List<Movie_Actor> Movie_Actor{ get; set; }

        //cinema
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinemas Cinema { get; set; }

        //productor
        public int ProductorId { get; set; }
        [ForeignKey("ProductorId")]
        public Productor productor { get; set; }
    }
}
