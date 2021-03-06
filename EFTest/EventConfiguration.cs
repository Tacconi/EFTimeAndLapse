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
    // Events
    public partial class EventConfiguration : EntityTypeConfiguration<Event>
    {
        public EventConfiguration()
            : this("dbo")
        {
        }
 
        public EventConfiguration(string schema)
        {
            ToTable(schema + ".Events");
            HasKey(x => x.EventId);

            Property(x => x.EventId).HasColumnName("EventID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.RaceId).HasColumnName("RaceID").IsRequired().HasColumnType("int");
            Property(x => x.CategoryId).HasColumnName("CategoryID").IsRequired().HasColumnType("int");
            Property(x => x.ChampionshipId).HasColumnName("ChampionshipID").IsRequired().HasColumnType("int");

            // Foreign keys
            HasRequired(a => a.Category).WithMany(b => b.Events).HasForeignKey(c => c.CategoryId); // FK__Events__Category__33D4B598
            HasRequired(a => a.Championship).WithMany(b => b.Events).HasForeignKey(c => c.ChampionshipId); // FK__Events__Champion__34C8D9D1
            HasRequired(a => a.Race).WithMany(b => b.Events).HasForeignKey(c => c.RaceId); // FK__Events__RaceID__32E0915F
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
