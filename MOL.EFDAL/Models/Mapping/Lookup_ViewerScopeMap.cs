namespace MOL.EFDAL.Models.Mapping
{
    using System.Data.Entity.ModelConfiguration;

    public class Lookup_ViewerScopeMap : EntityTypeConfiguration<Lookup_ViewerScope>
    {
        public Lookup_ViewerScopeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Lookup_ViewerScope");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
        }
    }
}
