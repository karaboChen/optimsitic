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
            //entity.HasQueryFilter(e => e.NAME == "123");
            //  在所有的where條件中都會自動加上這個條件
            //如果當下某一個查詢不需要這個條件，可以使用IgnoreQueryFilters()方法來忽略這個條件
        }
    }
}
