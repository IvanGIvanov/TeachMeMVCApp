using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeachMeMVCApp.Entities
{
    using static TeachMeMVCApp.Data.Constants.Common;
    using static TeachMeMVCApp.Data.Constants.Title;
    using static TeachMeMVCApp.Data.Constants.Description;
    using static TeachMeMVCApp.Data.Constants.DateFormat;

    public class CategoryItem
    {
        private DateTime _releaseDate = DateTime.MinValue;
        public int Id { get; set; }

        [Required(ErrorMessage = requiredFieldMessage)]
        [StringLength(maxTitleLength, MinimumLength = minTitleLength)]
        public string Title { get; set; }

        [Required(ErrorMessage = requiredFieldMessage)]
        [StringLength(maxDescriptionLength, MinimumLength = minDescriptionLength)]
        public string Description { get; set; }

        public int CategoryId { get; set; }

        [Required(ErrorMessage = requiredDropDownMessage)]
        [Display(Name = "Media type")]
        public int MediaTypeId { get; set; }

        [NotMapped]
        public virtual ICollection<SelectListItem> MediaTypes { get; set; }

        [DisplayFormat(DataFormatString = dateFormat)]
        [Display(Name = "Release date")]
        public DateTime DateTimeItemReleased 
        {
            get
            {
                return (_releaseDate == DateTime.MinValue) ? DateTime.Now : _releaseDate;
            }
            set
            {
                _releaseDate = value;
            }
        }

        [NotMapped]
        public int ContentId { get; set; }
    }
}
