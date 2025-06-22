using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public partial class ModelContext
    {
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new APPLEConfig());
        }
    }
}
