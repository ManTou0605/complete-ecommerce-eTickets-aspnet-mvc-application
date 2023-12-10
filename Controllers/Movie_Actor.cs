namespace eTickets.Controllers
{
    public class Movie_Actor
    {
        public int MovieId { get; set; }
        public Movies Movie { get; set; }

        public int ActorId { get; set; }
        public Actor Actor{ get; set;}

    }
}
