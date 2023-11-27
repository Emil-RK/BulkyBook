using System.ComponentModel.DataAnnotations;

namespace BulkyBookWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int DiaplsyOrder { get; set; }
        public DateTime CreateDateTime { get; set; } = DateTime.Now;

    }
}
