using System.ComponentModel.DataAnnotations;

namespace eTickets.Controllers
{
    public class Productor
    {
        [Key]     // [Key]  public int id { get; set; }    代表id是主鍵，可以用id 去辨識資料

        public int id { get; set; }

        public string profilePictureURL { get; set; }

        public string fullName { get; set; }

        public string bio { get; set; }

        //relationship
        public List<Movies> Movies { get; set; }
    }
}
