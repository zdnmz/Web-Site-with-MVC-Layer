using System.ComponentModel.DataAnnotations;

namespace FinalTUFOD.Models.Classes
{
    public class AdminPage
    {
        [Key]
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
}