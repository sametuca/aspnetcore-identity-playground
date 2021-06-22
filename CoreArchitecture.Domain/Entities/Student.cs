using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using CoreArchitecture.Domain.Entities.Base;

namespace CoreArchitecture.Domain.Entities
{
    [Table("Student", Schema = "Definition")]
    public class Student:IdEntity, IEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public virtual ICollection<Note> Notes { get; set; }
    }
}
