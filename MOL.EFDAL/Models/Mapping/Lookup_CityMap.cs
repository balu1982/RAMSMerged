namespace MOL.EFDAL.Models.Mapping
{
    using System.Data.Entity.ModelConfiguration;

    public class Lookup_CityMap : EntityTypeConfiguration<Lookup_City>
    {
        public Lookup_CityMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Lookup_City");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.CreatedOn).HasColumnName("CreatedOn");
            this.Property(t => t.ModifiedOn).HasColumnName("ModifiedOn");
        }
    }
}
