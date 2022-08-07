namespace Entidad
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Colegiala")]
    public partial class Colegiala
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        public int edad { get; set; }

        public int nivelcaliente { get; set; }

        public int estado { get; set; }

        [StringLength(50)]
        public string Tragona { get; set; }
    }
}
