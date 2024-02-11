using Abp.Domain.Entities.Auditing;
using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace OlaCollegeV1.Models
{
    public class Student : FullAuditedEntity<int>, IPassivable
    {
        public Student()
        {
            this.IsActive = true;
            this.CreationTime = DateTime.Now;
        }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string ProgramName { get; set; }

        public string DoB { get; set; }

        [ForeignKey("College")]
        public int CollegeId { get; set; }
        public virtual College College { get; set; } // Navigation property back to College

        public bool IsActive { get; set; }

    }
}
