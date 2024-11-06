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

    public partial class MyPortfolioTblAbout
    {
        [Required(ErrorMessage = "Id is required.")]
        public int AboutId { get; set; }
        [Required(ErrorMessage = "ImageUrl is required.")]
        public string ImageUrl { get; set; }
        [MaxLength(50, ErrorMessage = "Title cannot exceed 50 characters.")]
        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }
        [MaxLength(500, ErrorMessage = "Description cannot exceed 500 characters.")]
        [Required(ErrorMessage = "Description is required.")]
        public string Description { get; set; }
        [Required(ErrorMessage = "CvUrl is required.")]
        public string CvUrl { get; set; }
    }
}