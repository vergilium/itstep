using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB.Domain
{
    public class DbIdentity: IDbIdentity {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column ("id")]
        public long Id { get; set; }
    }
}
