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
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.17.1.0")]
    public partial class Partecipant
    {
        public int PartecipantId { get; set; } // PartecipantID (Primary key)
        public string FirstName { get; set; } // FirstName
        public string LastName { get; set; } // LastName
        public int Gender { get; set; } // Gender
        public string BloodGroup { get; set; } // BloodGroup
        public string PhoneNumber { get; set; } // PhoneNumber
        public DateTime BirthDate { get; set; } // BirthDate
        public string Address { get; set; } // Address
        public string License { get; set; } // License
        public string Insurance { get; set; } // Insurance
        public byte[] Photo { get; set; } // Photo

        // Reverse navigation
        public virtual ICollection<Registration> Registrations { get; set; } // Registrations.FK__Registrat__Parte__2D27B809
        
        public Partecipant()
        {
            Registrations = new List<Registration>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>