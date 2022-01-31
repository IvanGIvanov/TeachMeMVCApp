using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TeachMeMVCApp.Entities
{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "This field is required!")]
        [StringLength(100, MinimumLength = 2)]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please add description!")]
        public string Description { get; set; }

        [Required(ErrorMessage = "This field is required!")]
        [Display(Name = "Thumbnail Path")]
        public string ThumbnailImagePath { get; set; }

        [ForeignKey("CategoryId")]
        public virtual ICollection<CategoryItem> CategoryItems { get; set; }

        [ForeignKey("CategoryId")]
        public virtual ICollection<UserCategory> UserCategory { get; set; }
    }
}
