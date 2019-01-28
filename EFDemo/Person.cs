namespace EFDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Person")]
    public partial class Person
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Navn { get; set; }

        public int Alder { get; set; }

        public bool ErILive { get; set; }

        public DateTime Fødselsdato { get; set; }
    }
}
