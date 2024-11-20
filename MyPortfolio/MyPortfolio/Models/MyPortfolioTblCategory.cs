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

    public partial class MyPortfolioTblCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MyPortfolioTblCategory()
        {
            this.MyPortfolioTblProjects = new HashSet<MyPortfolioTblProject>();
        }
        [Key]
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(25, ErrorMessage = "Name name cannot exceed 25 characters.")]
        public string Name { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MyPortfolioTblProject> MyPortfolioTblProjects { get; set; }
    }
}
