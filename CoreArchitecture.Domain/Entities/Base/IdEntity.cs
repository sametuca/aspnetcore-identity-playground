using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CoreArchitecture.Domain.Entities.Base
{
    public class IdEntity<T>
    {
        [Key]
        public T Id { get; set; }
    }

    public class IdEntity : IdEntity<int>
    {

    }
}
