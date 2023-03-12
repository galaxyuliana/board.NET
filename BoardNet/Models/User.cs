using System.ComponentModel.DataAnnotations;

namespace BoardNet.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public string? Gender { get; set; }
        public decimal Age { get; set; }
    }
}
