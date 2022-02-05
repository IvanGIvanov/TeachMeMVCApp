using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeachMeMVCApp.Entities
{
    public class Content
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "This field is required!")]
        [StringLength(100, MinimumLength = 2)]
        public string Title { get; set; }

        [Required(ErrorMessage = "This field is required!")]
        [Display(Name = "HTML content")]
        public string HTMLContent { get; set; }

        [Required(ErrorMessage = "This field is required!")]
        [Display(Name = "Video link")]
        public string VideoLink { get; set; }

        public CategoryItem CategoryItem { get; set; }

        [NotMapped]
        public int CatItemId { get; set; }

        [NotMapped]
        public int CategoryId { get; set; }
    }
}
