using System.ComponentModel.DataAnnotations;

namespace FinalTUFOD.Models.Classes
{
    public class HomePage
    {
        [Key]
        public int id { get; set; }
        public string profile { get; set; }
        public string name { get; set; }
        public string content { get; set; }
        public string contant { get; set; }
        public string newshead { get; set; }
        public string news1head { get; set; }
        public string news1 { get; set; }
        public string news2head { get; set; }
        public string news2 { get; set; }
        public string news3head { get; set; }
        public string news3 { get; set; }
        public string news4head { get; set; }
        public string news4 { get; set; }
    }
}