using Model;
using System.Data.Entity;

namespace EfDataLayer
{

    public partial class EfDataModel : DbContext
    {
        public EfDataModel()
            : base("name=EfDataModel")
        {
        }

        public virtual DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
