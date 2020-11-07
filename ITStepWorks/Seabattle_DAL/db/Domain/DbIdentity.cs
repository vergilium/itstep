using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB.Domain
{
    public abstract class DbIdentity : DbIdentity<int> { }
        public abstract class DbIdentity<Tid> : IDbIdentity<Tid> {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column ("id")]
        public virtual Tid Id { get; set; }
        [NotMapped]
		public string StringId { 
            get => GetStringId(Id);
            set => GetTypedId(value);
        }

        protected virtual string GetStringId(Tid value) {
            return EqualityComparer<Tid>.Default.Equals(value, default) ? null : value.ToString();
        }

        protected virtual Tid GetTypedId(string value) {
            return string.IsNullOrEmpty(value) ? default : (Tid)Convert.ChangeType(value, typeof(Tid));
        }
    }
}
