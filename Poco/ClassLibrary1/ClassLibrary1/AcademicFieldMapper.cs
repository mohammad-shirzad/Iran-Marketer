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

    public class AcademicFieldMapper : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<AcademicField>
    {
        public AcademicFieldMapper()
            : this("dbo")
        {
        }

        public AcademicFieldMapper(string schema)
        {
            Property(x => x.TitleEn).IsOptional();
            Property(x => x.TitleFa).IsOptional();
            Property(x => x.Created).IsOptional();
            Property(x => x.CreatedBy).IsOptional();
            Property(x => x.Modified).IsOptional();
            Property(x => x.ModifiedBy).IsOptional();
        }
    }

}
// </auto-generated>
