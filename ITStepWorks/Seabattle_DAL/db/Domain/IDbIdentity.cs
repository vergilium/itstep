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
        public string StringId { get; set; }
    }

    public interface IDbIdentity<Tid> : IDbIdentity 
    {
        [Key]
        public Tid Id { get; set; }
    }
}
