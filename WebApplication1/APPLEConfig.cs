using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApplication1.Models
{
    public class APPLEConfig : IEntityTypeConfiguration<APPLE>
    {
        public void Configure(EntityTypeBuilder<APPLE> entity)
        {
            // 在這裡追加你需要的額外設定
            entity.Property(e => e.LOCK_VERSION)
                  .HasPrecision(10)
                  .IsConcurrencyToken();
        }
    }
}
