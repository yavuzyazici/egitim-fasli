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

    public partial class MyPortfolioTblMessage
    {
        [Required(ErrorMessage = "MessageId is required.")]
        public int MessageId { get; set; }
        [Required(ErrorMessage = "Name is required.")]
        [MaxLength(50, ErrorMessage = "Name can be max 50 character")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email is required.")]
        [MaxLength(50, ErrorMessage = "Email can be max 50 character")]
        public string Email { get; set; }
        [Required(ErrorMessage = "MessageContent is required.")]
        [MaxLength(500, ErrorMessage = "MessageContent can be max 500 character")]
        public string MessageContent { get; set; }
        [Required(ErrorMessage = "IsRead is required.")]
        public bool IsRead { get; set; }
        public Nullable<System.DateTime> MessageDate { get; set; }
    }
}