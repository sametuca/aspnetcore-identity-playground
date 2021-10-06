using CoreArchitecture.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreArchitecture.Domain.Entities
{
    [Table("Note", Schema = "Definition")]
    public class Note : IdEntity, IEntity
    {
        public int Note1 { get; set; }
        public int Note2 { get; set; }
        public int Note3 { get; set; }
        public int StudentId { get; set; }
    }
}
