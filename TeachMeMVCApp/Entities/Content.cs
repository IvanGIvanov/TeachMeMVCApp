using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeachMeMVCApp.Entities
{
    using static TeachMeMVCApp.Data.Constants.Common;
    using static TeachMeMVCApp.Data.Constants.Title;

    public class Content
    {
        public int Id { get; set; }

        [Required(ErrorMessage = requiredFieldMessage)]
        [StringLength(maxTitleLength, MinimumLength = minTitleLength)]
        public string Title { get; set; }

        [Required(ErrorMessage = requiredFieldMessage)]
        [Display(Name = "HTML content")]
        public string HTMLContent { get; set; }

        [Required(ErrorMessage = requiredFieldMessage)]
        [Display(Name = "Video link")]
        public string VideoLink { get; set; }

        public CategoryItem CategoryItem { get; set; }

        [NotMapped]
        public int CatItemId { get; set; }

        [NotMapped]
        public int CategoryId { get; set; }
    }
}
