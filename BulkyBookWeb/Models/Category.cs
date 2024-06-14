using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyBookWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [DisplayName("Diaplsy Order")]
        [Range(1,1000,ErrorMessage ="Display order must be between 1 and 1000 only!")]
        public int DiaplsyOrder { get; set; }
        public DateTime CreateDateTime { get; set; } = DateTime.Now;

    }
}
