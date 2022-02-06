using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeachMeMVCApp.Interfaces;

namespace TeachMeMVCApp.Entities
{
    using static TeachMeMVCApp.Data.Constants.Common;
    using static TeachMeMVCApp.Data.Constants.Title;

    public class MediaType : IPrimaryProperties
    {
        public int Id { get; set; }

        [Required(ErrorMessage = requiredFieldMessage)]
        [StringLength(maxTitleLength, MinimumLength = minTitleLength)]
        public string Title { get; set; }

        [Required(ErrorMessage = requiredFieldMessage)]
        [Display(Name = "Thumbnail path")]
        public string ThumbnailImagePath { get; set; }

        [ForeignKey("MediaTypeId")]
        public virtual ICollection<CategoryItem> CategoryItems { get; set; }
    }
}
