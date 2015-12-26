// <auto-generated>
// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Data.Entity.Infrastructure;
using System.Linq.Expressions;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Entity.ModelConfiguration;
using System.Threading;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace EFTest
{
    // Partecipants
    public partial class PartecipantConfiguration : EntityTypeConfiguration<Partecipant>
    {
        public PartecipantConfiguration()
            : this("dbo")
        {
        }
 
        public PartecipantConfiguration(string schema)
        {
            ToTable(schema + ".Partecipants");
            HasKey(x => x.PartecipantId);

            Property(x => x.PartecipantId).HasColumnName("PartecipantID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.FirstName).HasColumnName("FirstName").IsRequired().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.LastName).HasColumnName("LastName").IsRequired().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.Gender).HasColumnName("Gender").IsRequired().HasColumnType("int");
            Property(x => x.BloodGroup).HasColumnName("BloodGroup").IsRequired().HasColumnType("nvarchar").HasMaxLength(7);
            Property(x => x.PhoneNumber).HasColumnName("PhoneNumber").IsRequired().HasColumnType("nvarchar").HasMaxLength(10);
            Property(x => x.BirthDate).HasColumnName("BirthDate").IsRequired().HasColumnType("datetime");
            Property(x => x.Address).HasColumnName("Address").IsRequired().HasColumnType("nvarchar").HasMaxLength(40);
            Property(x => x.License).HasColumnName("License").IsRequired().HasColumnType("nvarchar").HasMaxLength(40);
            Property(x => x.Insurance).HasColumnName("Insurance").IsRequired().HasColumnType("nvarchar").HasMaxLength(30);
            Property(x => x.Photo).HasColumnName("Photo").IsRequired().HasColumnType("image").HasMaxLength(2147483647);
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
