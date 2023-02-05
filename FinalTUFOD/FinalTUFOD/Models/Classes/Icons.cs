using System.ComponentModel.DataAnnotations;

namespace FinalTUFOD.Models.Classes
{
    public class Icons
    {
        [Key]
        public int id { get; set; }
        public string icon { get; set; }
        public string link { get; set; }
    }
}