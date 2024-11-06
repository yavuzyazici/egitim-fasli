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
    using System.ComponentModel.DataAnnotations;
    using System.Collections.Generic;
    
    public partial class MyPortfolioTblTestimonial
    {
        [Required(ErrorMessage = "TestimonialId is required.")]
        public int TestimonialId { get; set; }
        [Required(ErrorMessage = "NameSurname is required.")]
        [MaxLength(50, ErrorMessage = "NameSurname can be max 50 character")]
        public string NameSurname { get; set; }
        [Required(ErrorMessage = "Title is required.")]
        [MaxLength(50, ErrorMessage = "Title can be max 50 character")]
        public string Title { get; set; }
        [Required(ErrorMessage = "ImageUrl is required.")]
        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "Comment is required.")]
        [MaxLength(250, ErrorMessage = "Comment can be max 250 character")]
        public string Comment { get; set; }
    }
}
