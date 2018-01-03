using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ProjectRider.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [AllowHtml]
        public string Title { get; set; }

        [Required]
        [AllowHtml]
        public string Description { get; set; }

        [Required]
        [AllowHtml]
        public long Budget { get; set; }
    }
}