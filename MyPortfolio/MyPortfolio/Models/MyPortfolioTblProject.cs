//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyPortfolio.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class MyPortfolioTblProject
    {
        [Key]
        public int ProjectId { get; set; }

        [Required(ErrorMessage = "Project name is required.")]
        [StringLength(100, ErrorMessage = "Project name cannot exceed 100 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Image URL is required.")]
        [Url(ErrorMessage = "Please provide a valid URL for the image.")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "Description is required.")]
        [StringLength(400, ErrorMessage = "Description cannot exceed 400 characters.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Category is required.")]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Github Url is required.")]
        public string GithubUrl { get; set; }

        public virtual MyPortfolioTblCategory MyPortfolioTblCategory { get; set; }
    }
}
