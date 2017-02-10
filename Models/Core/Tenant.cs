using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biscuit.Models.Core
{
    [Table("tenants", Schema="core")]
    public class Tenant
    {
        [Key]
        [Column("id")]
        public string Id { get; set; }

        [Required]
        [Column("description")]
        public string description { get; set; }
    }
}