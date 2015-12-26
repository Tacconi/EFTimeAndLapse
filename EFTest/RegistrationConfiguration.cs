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
    // Registrations
    public partial class RegistrationConfiguration : EntityTypeConfiguration<Registration>
    {
        public RegistrationConfiguration()
            : this("dbo")
        {
        }
 
        public RegistrationConfiguration(string schema)
        {
            ToTable(schema + ".Registrations");
            HasKey(x => x.RegistrationId);

            Property(x => x.RegistrationId).HasColumnName("RegistrationID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Share).HasColumnName("Share").IsRequired().HasColumnType("nvarchar").HasMaxLength(10);
            Property(x => x.Note).HasColumnName("Note").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.PartecipantId).HasColumnName("PartecipantID").IsRequired().HasColumnType("int");
            Property(x => x.RaceId).HasColumnName("RaceID").IsRequired().HasColumnType("int");

            // Foreign keys
            HasRequired(a => a.Partecipant).WithMany(b => b.Registrations).HasForeignKey(c => c.PartecipantId); // FK__Registrat__Parte__2D27B809
            HasRequired(a => a.Race).WithMany(b => b.Registrations).HasForeignKey(c => c.RaceId); // FK__Registrat__RaceI__2E1BDC42
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>