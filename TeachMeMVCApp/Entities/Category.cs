using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeachMeMVCApp.Entities
{
    using static TeachMeMVCApp.Data.Constants.Common;
    using static TeachMeMVCApp.Data.Constants.Title;
    using static TeachMeMVCApp.Data.Constants.Description;
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage = requiredFieldMessage)]
        [StringLength(maxTitleLength, MinimumLength = minTitleLength)]
        public string Title { get; set; }

        [Required(ErrorMessage = requiredFieldMessage)]
        [StringLength(maxDescriptionLength, MinimumLength = minDescriptionLength)]
        public string Description { get; set; }

        [Required(ErrorMessage = requiredFieldMessage)]
        [Display(Name = "Thumbnail Path")]
        public string ThumbnailImagePath { get; set; }

        [ForeignKey("CategoryId")]
        public virtual ICollection<CategoryItem> CategoryItems { get; set; }

        [ForeignKey("CategoryId")]
        public virtual ICollection<UserCategory> UserCategory { get; set; }
    }
}
