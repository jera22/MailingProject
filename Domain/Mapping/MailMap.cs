using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mapping
{
    public class MailMap
    {
        public MailMap(EntityTypeBuilder<Mail> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.Property(t => t.From).IsRequired();
            entityBuilder.Property(t => t.To).IsRequired();
            entityBuilder.Property(t => t.CC);
            entityBuilder.Property(t => t.Subject).IsRequired();
            entityBuilder.Property(t => t.Body).IsRequired();
            entityBuilder.Property(t => t.Importance).IsRequired();
        }
    }
}
