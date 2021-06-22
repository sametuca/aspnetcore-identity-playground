using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using CoreArchitecture.Domain.Entities.Base;

namespace CoreArchitecture.Domain.Entities
{
    [Table("Note",Schema = "Definition")]
    public class Note:IdEntity
    {
        public string Name { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
