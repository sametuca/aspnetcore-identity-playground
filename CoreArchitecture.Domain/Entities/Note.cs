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
        public int Note1 { get; set; }
        public int Note2 { get; set; }
        public int Note3 { get; set; }
    }
}
