using System.Collections.Generic;
using CoreArchitecture.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;
using CoreArchitecture.Core.Abstract;

namespace CoreArchitecture.Domain.Entities
{
    [Table("Note", Schema = "Definition")]
    public class Note : IdEntity, IEntity
    {
        public List<int> Notes { get; set; }
        public int StudentId { get; set; }
    }
}
