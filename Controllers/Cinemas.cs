namespace eTickets.Controllers
{
    public class Cinemas
    {
        public int Id { get; set; }

        public string Logo { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        //relationship
        public List<Movies> Movies { get; set; }

    }
}
