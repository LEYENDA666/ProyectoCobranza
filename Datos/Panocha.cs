namespace Datos
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Entidad;

    public partial class Panocha : DbContext
    {
        public Panocha()
            : base("name=Panocha")
        {
        }

        public virtual DbSet<Colegiala> Colegiala { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
