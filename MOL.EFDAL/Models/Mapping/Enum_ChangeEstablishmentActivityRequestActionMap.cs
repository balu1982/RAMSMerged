namespace MOL.EFDAL.Models.Mapping
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.ModelConfiguration;

    public class Enum_ChangeEstablishmentActivityRequestActionMap : EntityTypeConfiguration<Enum_ChangeEstablishmentActivityRequestAction>
    {
        public Enum_ChangeEstablishmentActivityRequestActionMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("Enum_ChangeEstablishmentActivityRequestAction");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.CreatedOn).HasColumnName("CreatedOn");
            this.Property(t => t.ModifiedOn).HasColumnName("ModifiedOn");
        }
    }
}