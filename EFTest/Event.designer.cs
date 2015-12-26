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
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.17.1.0")]
    public partial class Event
    {
        public int EventId { get; set; } // EventID (Primary key)
        public int RaceId { get; set; } // RaceID
        public int CategoryId { get; set; } // CategoryID
        public int ChampionshipId { get; set; } // ChampionshipID

        // Reverse navigation
        public virtual ICollection<Player> Players { get; set; } // Players.FK__Players__EventID__31EC6D26

        // Foreign keys
        public virtual Category Category { get; set; } // FK__Events__Category__33D4B598
        public virtual Championship Championship { get; set; } // FK__Events__Champion__34C8D9D1
        public virtual Race Race { get; set; } // FK__Events__RaceID__32E0915F
        
        public Event()
        {
            Players = new List<Player>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
