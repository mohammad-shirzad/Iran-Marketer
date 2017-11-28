// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.6
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IranMarketer.Domain.Entity
{

    [Table("JobPrefer", Schema = "dbo")]
    public class JobPrefer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"Id", Order = 1, TypeName = "int")]
        [Index(@"PK_JobPrefer", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Column(@"ExpectedSalary", Order = 2, TypeName = "int")]
        [Display(Name = "Expected salary")]
        public int? ExpectedSalary { get; set; }

        [Column(@"BusinessTrips", Order = 3, TypeName = "int")]
        [Display(Name = "Business trips")]
        public int? BusinessTrips { get; set; }

        [Column(@"Relocate", Order = 4, TypeName = "int")]
        [Display(Name = "Relocate")]
        public int? Relocate { get; set; }

        [Column(@"PartyId", Order = 5, TypeName = "int")]
        [Required]
        [Display(Name = "Party ID")]
        public int PartyId { get; set; }

        [Column(@"Created", Order = 6, TypeName = "datetime")]
        [Display(Name = "Created")]
        public System.DateTime? Created { get; set; }

        [Column(@"CreatedBy", Order = 7, TypeName = "nvarchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Created by")]
        public string CreatedBy { get; set; }

        [Column(@"Modified", Order = 8, TypeName = "datetime")]
        [Display(Name = "Modified")]
        public System.DateTime? Modified { get; set; }

        [Column(@"ModifiedBy", Order = 9, TypeName = "nchar")]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Modified by")]
        public string ModifiedBy { get; set; }

        public System.Collections.Generic.ICollection<JobPreferIndustry> JobPreferIndustries { get; set; } = new System.Collections.Generic.List<JobPreferIndustry>();
        public System.Collections.Generic.ICollection<JobPreferJobCategory> JobPreferJobCategories { get; set; } = new System.Collections.Generic.List<JobPreferJobCategory>();


        [ForeignKey("PartyId")] public RetailParty RetailParty { get; set; }
    }

}
// </auto-generated>
