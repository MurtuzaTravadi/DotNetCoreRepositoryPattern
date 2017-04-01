using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DotNetCoreRepositoryPattern.Models.Domain.Model
{
    public class User
    {

        public User()
        {

        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public long Number { get; set; }
        public bool IsActive { get; set; }
        public bool IsFaculty { get; set; }
        public bool SoftDelete { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedDate{ get; set; }
        public int ModifiedBy { get; set; }

        public ICollection<UserSubjectMapping> UserSubjectMappings { get; set; }

    }
}
