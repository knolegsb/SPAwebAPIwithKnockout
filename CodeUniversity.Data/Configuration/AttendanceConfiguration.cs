using CodeUniversity.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeUniversity.Data.Configuration
{
    class AttendanceConfiguration : EntityTypeConfiguration<Attendance>
    {
        public AttendanceConfiguration()
        {
            // Attendance has a composite key : SessionId and PersonId
            HasKey(a => new { a.SessionId, a.PersonId });

            // Attendance has 1 Session, Sessions have many Attendance records
            HasRequired(a => a.Session)
                .WithMany(s => s.AttendanceList)
                .HasForeignKey(a => a.SessionId)
                .WillCascadeOnDelete(false);

            // Attendance has 1 person, Persons have many Attendance records
            HasRequired(a => a.Person)
                .WithMany(p => p.AttendanceList)
                .HasForeignKey(a => a.PersonId)
                .WillCascadeOnDelete(false);
        }
    }
}
