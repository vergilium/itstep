using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DB.Domain
{
    public interface IDbIdentity
    {
        [Key]
        public Guid Id { get; set; }
    }
}
