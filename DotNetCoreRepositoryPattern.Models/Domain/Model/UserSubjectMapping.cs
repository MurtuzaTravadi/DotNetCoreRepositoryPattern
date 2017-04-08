using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DotNetCoreRepositoryPattern.Models.Domain.Model
{
    public class UserSubjectMapping
    {
        public UserSubjectMapping()
        {

        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public bool SoftDelete { get; set; }
        public int UserId { get; set; }
        public int SubjectId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int ModifiedBy { get; set; }

        public User User { get; set; }
        public Subject Subject { get; set; }

    }
}
