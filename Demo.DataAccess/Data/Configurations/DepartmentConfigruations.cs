
namespace Demo.DataAccess.Data.Configurations
{
    internal class DepartmentConfigruations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.Property(D => D.Id).UseIdentityColumn(10 , 10);
            builder.Property(D => D.Name).HasColumnType("Varchar(20)");
            builder.Property(D => D.Code).HasColumnType("Varchar(20)");
            builder.Property(D => D.CreatedOn).HasComputedColumnSql("GETDATE()");
            builder.Property(D => D.ModifiedOn).HasComputedColumnSql("GETDATE()");

        }
    }
}
