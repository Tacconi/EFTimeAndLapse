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
    // Manches
    public partial class ManchConfiguration : EntityTypeConfiguration<Manch>
    {
        public ManchConfiguration()
            : this("dbo")
        {
        }
 
        public ManchConfiguration(string schema)
        {
            ToTable(schema + ".Manches");
            HasKey(x => x.MancheId);

            Property(x => x.MancheId).HasColumnName("MancheID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasColumnType("nvarchar").HasMaxLength(10);
            Property(x => x.Description).HasColumnName("Description").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.PlayerId).HasColumnName("PlayerID").IsRequired().HasColumnType("int");
            Property(x => x.RoundId).HasColumnName("RoundID").IsRequired().HasColumnType("int");
            Property(x => x.RunId).HasColumnName("RunID").IsRequired().HasColumnType("int");
            Property(x => x.TournamentId).HasColumnName("TournamentID").IsRequired().HasColumnType("int");

            // Foreign keys
            HasRequired(a => a.Manch_TournamentId).WithMany(b => b.Manches).HasForeignKey(c => c.TournamentId); // FK__Manches__Tournam__3D5E1FD2
            HasRequired(a => a.Player).WithMany(b => b.Manches).HasForeignKey(c => c.PlayerId); // FK__Manches__PlayerI__3A81B327
            HasRequired(a => a.Round).WithMany(b => b.Manches).HasForeignKey(c => c.RoundId); // FK__Manches__RoundID__3B75D760
            HasRequired(a => a.Run).WithMany(b => b.Manches).HasForeignKey(c => c.RunId); // FK__Manches__RunID__3C69FB99
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
