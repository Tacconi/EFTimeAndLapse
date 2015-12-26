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
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.17.1.0")]
    public partial class Registration
    {
        public int RegistrationId { get; set; } // RegistrationID (Primary key)
        public string Share { get; set; } // Share
        public string Note { get; set; } // Note
        public int PartecipantId { get; set; } // PartecipantID
        public int RaceId { get; set; } // RaceID

        // Reverse navigation
        public virtual ICollection<Player> Players { get; set; } // Players.FK__Players__Registr__2F10007B

        // Foreign keys
        public virtual Partecipant Partecipant { get; set; } // FK__Registrat__Parte__2D27B809
        public virtual Race Race { get; set; } // FK__Registrat__RaceI__2E1BDC42
        
        public Registration()
        {
            Players = new List<Player>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>