using System.ComponentModel.DataAnnotations;

namespace ESite.Web.Models
{
    public class Category
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string? Name { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime CeatedDateTime { get; set; } = DateTime.Now;
    }
}
